using AutoMapper;
using JobSearch.WebAPI.Database;
using JobSearch.WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.Service
{
    public class JobLevelService : BaseCRUDService<Model.JobLevel, object, Database.JobLevel, JobLevelUpsert, JobLevelUpsert>
    {
        public JobLevelService(SearchJobContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
