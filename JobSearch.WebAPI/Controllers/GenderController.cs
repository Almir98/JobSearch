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
    [Route("api/[controller]")]
    [ApiController]
    public class GenderController : BaseController<Model.Gender, object>
    {
        public GenderController(IService<Gender, object> service) : base(service)
        {
        }
    }
}