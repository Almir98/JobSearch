using AutoMapper;
using JobSearch.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.Service
{
    public class GenderService : BaseService<Model.Gender, object, Database.Gender>
    {
        public GenderService(SearchJobContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
