using AutoMapper;
using JobSearch.WebAPI.Database;
using JobSearch.WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.Service
{
    public class CategoryService : BaseCRUDService<Model.Category, object, Database.Category, CategoryUpsertVM, CategoryUpsertVM>
    {
        public CategoryService(SearchJobContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
