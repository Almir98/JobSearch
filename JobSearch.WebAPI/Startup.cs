using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using JobSearch.WebAPI.Database;
using JobSearch.WebAPI.Helpers;
using JobSearch.WebAPI.Interface;
using JobSearch.WebAPI.Service;
using JobSearch.WebAPI.ViewModels;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace JobSearch.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //Connection string
            services.AddDbContext<SearchJobContext>(c => c.UseSqlServer(Configuration.GetConnectionString("JobSearch"))
           .EnableSensitiveDataLogging());

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>        // CORS Policy
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services.AddAutoMapper(typeof(Startup));      // Automapper         
            services.AddSwaggerGen();                    // Swagger API
            services.AddControllers();

            services.AddControllersWithViews()
              .AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                );

            //JWT
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).
                AddJwtBearer(opt => {
                    opt.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration.GetSection("AppSettings:Token").Value)),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });

            // Repository pattern
            services.AddScoped<IUserRepository,UserService>();

            // Get and GetById services

            services.AddScoped<IService<Model.City, object>, BaseService<Model.City, object, Database.City>>();
            services.AddScoped<IService<Model.Gender, object>, BaseService<Model.Gender, object, Database.Gender>>();

            //CRUD services

            services.AddScoped<IService<Model.Country, object>, BaseService<Model.Country, object, Database.Country>>();

            services.AddScoped<ICRUDService<Model.Question,object,QuestionUpsert,QuestionUpsert>,BaseCRUDService<Model.Question,object,Database.Question,QuestionUpsert,QuestionUpsert>>();
            services.AddScoped<ICRUDService<Model.Advertisment, object, AdvertismentUpsertVM, AdvertismentUpsertVM>, AdvertismentService>();
            services.AddScoped<ICRUDService<Model.Application, object, ApplicationUpsertVM, ApplicationUpsertVM>, ApplicationService>();
            services.AddScoped<ICRUDService<Model.City, object, CityUpsertVM, CityUpsertVM>, CityService>();
        

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //Global exception Handling in .NET Core

                app.UseExceptionHandler(builder => builder.Run(async context => {

                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                    var error = context.Features.Get<IExceptionHandlerFeature>();

                    if (error != null)
                    {
                        context.Response.AddApplicationError(error.Error.Message);

                        await context.Response.WriteAsync(error.Error.Message);
                    }
                }));
            }

            app.UseCors("MyPolicy");
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSwagger()
                .UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Job Search API");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
