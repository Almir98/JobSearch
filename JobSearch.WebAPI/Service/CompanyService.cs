using AutoMapper;
using java.io;
using java.net;
using JobSearch.Model;
using JobSearch.WebAPI.Database;
using JobSearch.WebAPI.Interface;
using JobSearch.WebAPI.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.Service
{
    public class CompanyService : IComapany
    {
        protected readonly SearchJobContext _context;
        private readonly IWebHostEnvironment _hosting;
        protected readonly IMapper _mapper;

        public CompanyService(SearchJobContext searchJob, IMapper mapper, IWebHostEnvironment hostingEnvironment)
        {
            _context = searchJob;
            _mapper = mapper;
            _hosting = hostingEnvironment;
        }

        public List<Model.Company> GetAll()
        {
            var entity = _context.Company.ToList();
            return _mapper.Map<List<Model.Company>>(entity);
        }

        public Model.Company GetById(int id)
        {
            var entity = _context.Company.FirstOrDefault(e => e.CompanyId == id);
            return _mapper.Map<Model.Company>(entity);
        }

        public static JsonObject generateJSON()
        {
            String s = "http://www.example.com";
            s.Replace("/", "\\/");

            JsonObject reqparam = new JsonObject();
            reqparam.Add("type", "arl");
            reqparam.Add("action", "remove");
            reqparam.Add("domain", "staging");
            reqparam.Add("objects", s);
            return reqparam;
        }

    public Model.Company Insert(CompanyUpsertVM request, IFormFile file)
        {
            if (file.Length > 0)
            {
               if (!Directory.Exists(_hosting.WebRootPath + "\\Upload"))
               {
                   Directory.CreateDirectory(_hosting.WebRootPath + "\\Upload");
               }
               using (FileStream fileStream = System.IO.File.Create(_hosting.WebRootPath + "\\Upload" + request.Photo.FileName))
               {
                   request.Photo.CopyTo(fileStream);
                   fileStream.Flush();
                   //return "\\Upload\\" + request.Photo.FileName;
               }
            }
           
            Database.Company company = new Database.Company
            {
                CompanyName = request.CompanyName,
                Phone = request.Phone,
                Email = request.Email,
                Adress = request.Adress,
                Photo = file.FileName,
                AboutUs = request.AboutUs,
                Url = request.Url
            };

            return null;
        }
    }
}
