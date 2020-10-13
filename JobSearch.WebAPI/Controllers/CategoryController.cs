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
    public class CategoryController : BaseCRUDController<Model.Category, object, CategoryUpsertVM, CategoryUpsertVM>
    {
        public CategoryController(ICRUDService<Category, object, CategoryUpsertVM, CategoryUpsertVM> service) : base(service)
        {
        }
    }
}