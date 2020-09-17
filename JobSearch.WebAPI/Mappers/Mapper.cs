using AutoMapper;
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
            CreateMap<Database.Advertisment, Model.Data.Advertisment>();
            CreateMap<Database.AdvertismentSkill, Model.Data.AdvertismentSkill>();
            CreateMap<Database.Application, Model.Data.Application>();
            CreateMap<Database.Category, Model.Data.Category>();
            CreateMap<Database.City, Model.Data.City>();
            CreateMap<Database.Company, Model.Data.Company>();
            CreateMap<Database.Gender, Model.Data.Gender>();
            CreateMap<Database.JobLevel, Model.Data.JobLevel>();
            CreateMap<Database.JobType, Model.Data.JobType>();
            CreateMap<Database.Skill, Model.Data.Skill>();
            CreateMap<Database.Users, Model.Data.Users>();
            CreateMap<Database.UserType, Model.Data.UserType>();

        }
    }
}
