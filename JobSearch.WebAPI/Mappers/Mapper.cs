using AutoMapper;
using JobSearch.WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Database.Advertisment, Model.Advertisment>().ReverseMap();
            CreateMap<Database.AdvertismentSkill, Model.AdvertismentSkill>().ReverseMap();
            CreateMap<Database.Application, Model.Application>().ReverseMap();
            CreateMap<Database.Category, Model.Category>().ReverseMap();
            CreateMap<Database.City, Model.City>().ReverseMap();
            CreateMap<Database.Country, Model.Country>().ReverseMap();

            CreateMap<Database.Company, Model.Company>().ReverseMap();
            CreateMap<Database.Gender, Model.Gender>().ReverseMap();
            CreateMap<Database.JobLevel, Model.JobLevel>().ReverseMap();
            CreateMap<Database.JobType, Model.JobType>().ReverseMap();
            CreateMap<Database.Skill, Model.Skill>().ReverseMap();
            CreateMap<Database.Users, Model.Users>().ReverseMap();
            CreateMap<Database.UserType, Model.UserType>().ReverseMap();

            CreateMap<UserVM, Database.Users>().ReverseMap();

            CreateMap<UserUpsertVM, Database.Users>().ReverseMap();

            CreateMap<QuestionUpsert, Database.Question>().ReverseMap();
            CreateMap<Model.Question, Database.Question>().ReverseMap();


            CreateMap<AdvertismentUpsertVM, Database.Advertisment>().ReverseMap();
            CreateMap<Model.Advertisment, Database.Advertisment>().ReverseMap();

            CreateMap<ApplicationUpsertVM, Database.Application>().ReverseMap();
            CreateMap<Model.Application, Database.Application>().ReverseMap();

            CreateMap<JobTypeUpsertVM, Database.JobType>().ReverseMap();
            CreateMap<Model.JobType, Database.JobType>().ReverseMap();


            CreateMap<CityUpsertVM, Database.City>().ReverseMap();
            CreateMap<Model.City, Database.City>().ReverseMap();

            CreateMap<CompanyUpsertVM, Database.Company>().ReverseMap();
            CreateMap<Model.Company, Database.Company>().ReverseMap();


        }
    }
}
