using AutoMapper;
using JobSearch.WebAPI.Database;
using JobSearch.WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.Service
{
    public class QuestionService : BaseCRUDService<Model.Question, object, Database.Question, QuestionUpsert, QuestionUpsert>
    {
        public QuestionService(SearchJobContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
