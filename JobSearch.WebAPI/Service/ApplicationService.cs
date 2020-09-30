using AutoMapper;
using JobSearch.WebAPI.Database;
using JobSearch.WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.Service
{
    public class ApplicationService : BaseCRUDService<Model.Application, object, Database.Application, ApplicationUpsertVM, ApplicationUpsertVM>
    {
        public ApplicationService(SearchJobContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
