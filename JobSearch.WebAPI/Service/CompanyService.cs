using AutoMapper;
using JobSearch.WebAPI.Database;
using JobSearch.WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.Service
{
    public class CompanyService : BaseCRUDService<Model.Company, object, Database.Company, CompanyUpsertVM, CompanyUpsertVM>
    {
        public CompanyService(SearchJobContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
