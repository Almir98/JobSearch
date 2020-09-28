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
    public class AdvertismentController : BaseCRUDController<Model.Advertisment, object, AdvertismentUpsertVM, AdvertismentUpsertVM>
    {
        public AdvertismentController(ICRUDService<Advertisment, object, AdvertismentUpsertVM, AdvertismentUpsertVM> service) : base(service)
        {
        }
    }
}