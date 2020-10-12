using AutoMapper;
using JobSearch.WebAPI.Database;
using JobSearch.WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.Service
{
    public class SkillService : BaseCRUDService<Model.Skill, object, Database.Skill, SkillUpsert, SkillUpsert>
    {
        public SkillService(SearchJobContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
