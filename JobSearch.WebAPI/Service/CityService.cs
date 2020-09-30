using AutoMapper;
using JobSearch.WebAPI.Database;
using JobSearch.WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.Service
{
    public class CityService : BaseCRUDService<Model.City, object, Database.City, CityUpsertVM, CityUpsertVM>
    {
        public CityService(SearchJobContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
