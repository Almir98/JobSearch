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
    public class JobTypeController : BaseCRUDController<Model.JobType, object, JobTypeUpsertVM, JobTypeUpsertVM>
    {
        public JobTypeController(ICRUDService<JobType, object, JobTypeUpsertVM, JobTypeUpsertVM> service) : base(service)
        {
        }
    }
}