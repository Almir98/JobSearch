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
    public class ApplicationController : BaseCRUDController<Model.Application, object, ApplicationUpsertVM, ApplicationUpsertVM>
    {
        public ApplicationController(ICRUDService<Application, object, ApplicationUpsertVM, ApplicationUpsertVM> service) : base(service)
        {
        }
    }
}