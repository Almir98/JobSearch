using AutoMapper;
using JobSearch.WebAPI.Database;
using JobSearch.WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.Service
{
    public class JobTypeService : BaseCRUDService<Model.JobType, object, Database.JobType, JobTypeUpsertVM, JobTypeUpsertVM>
    {
        public JobTypeService(SearchJobContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
