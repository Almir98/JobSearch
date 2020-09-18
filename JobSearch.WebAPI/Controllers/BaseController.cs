using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSearch.WebAPI.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearch.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TModel,Tsearch> : Controller
    {
        protected readonly IService<TModel, Tsearch> _service;
        public BaseController(IService<TModel,Tsearch> service)
        {
            _service = service;
        }

        [HttpGet]
        public List<TModel> Get([FromQuery]Tsearch search)
        {
            return _service.Get(search);
        }

        [HttpGet("id")]
        public TModel GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpDelete("id")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}