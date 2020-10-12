using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSearch.Model;
using JobSearch.WebAPI.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearch.WebAPI.Controllers
{
    public class CategoryController : BaseController<Model.Category, object>
    {
        public CategoryController(IService<Category, object> service) : base(service)
        {
        }
    }
}