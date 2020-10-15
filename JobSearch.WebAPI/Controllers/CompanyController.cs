using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using java.util.function;
using JobSearch.Model;
using JobSearch.WebAPI.Interface;
using JobSearch.WebAPI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static java.awt.PageAttributes;

namespace JobSearch.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : Controller
    {
        protected readonly IComapany _companyService;

        public CompanyController(IComapany comapany)
        {
            _companyService = comapany;
        }

        [HttpGet]
        public List<Model.Company> GetAll()
        {
            return _companyService.GetAll();
        }

        [HttpGet("id")]
        public Model.Company GetById(int id)
        {
            return _companyService.GetById(id);
        }

        [HttpPost]
        public Model.Company Insert(CompanyUpsertVM company, IFormFile file)
        {
            return _companyService.Insert(company,file);
        }
    }
}