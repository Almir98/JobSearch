using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSearch.Model;
using JobSearch.WebAPI.Interface;
using JobSearch.WebAPI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearch.WebAPI.Controllers
{
    public class SkillController : BaseCRUDController<Model.Skill, object, SkillUpsert, SkillUpsert>
    {
        public SkillController(ICRUDService<Skill, object, SkillUpsert, SkillUpsert> service) : base(service)
        {
        }
    }
}