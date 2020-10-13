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
    public class JobLevelController : BaseCRUDController<Model.JobLevel, object, JobLevelUpsert, JobLevelUpsert>
    {
        public JobLevelController(ICRUDService<JobLevel, object, JobLevelUpsert, JobLevelUpsert> service) : base(service)
        {
        }
    }
}