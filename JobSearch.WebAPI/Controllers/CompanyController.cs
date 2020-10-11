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
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : BaseCRUDController<Model.Company, object, CompanyUpsertVM, CompanyUpsertVM>
    {
        public CompanyController(ICRUDService<Company, object, CompanyUpsertVM, CompanyUpsertVM> service) : base(service)
        {
        }
    }
}