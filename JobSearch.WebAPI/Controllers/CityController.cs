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
    public class CityController : BaseCRUDController<Model.City, object, CityUpsertVM, CityUpsertVM>
    {
        public CityController(ICRUDService<City, object, CityUpsertVM, CityUpsertVM> service) : base(service)
        {
        }
    }
}