using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSearch.Model.Data;
using JobSearch.WebAPI.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearch.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : BaseController<Model.Data.City, object>
    {
        public CityController(IService<City, object> service) : base(service)
        {
        }
    }
}