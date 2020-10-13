using AutoMapper;
using JobSearch.WebAPI.Database;
using JobSearch.WebAPI.ViewModels;
using Microsoft.EntityFrameworkCore;
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

        public override List<Model.Application> Get(object search)
        {
            var query = _context.Application
               .Include(e => e.Advertisment)
               .Include(e => e.User)
               .Include(e => e.Advertisment.City)
               .AsQueryable();

            return _mapper.Map<List<Model.Application>>(query.ToList());
        }

        public override Model.Application GetById(int id)
        {
            var query = _context.Application.Where(e => e.ApplicationId == id)
               .Include(e => e.Advertisment)
               .Include(e => e.User)
               .Include(e => e.Advertisment.Company)
               .Include(e => e.Advertisment.City).FirstOrDefault();

            return _mapper.Map<Model.Application>(query);
        }
    }
}
