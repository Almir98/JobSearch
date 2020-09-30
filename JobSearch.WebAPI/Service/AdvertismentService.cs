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
    public class AdvertismentService : BaseCRUDService<Model.Advertisment, object, Database.Advertisment, AdvertismentUpsertVM, AdvertismentUpsertVM>
    {
        public AdvertismentService(SearchJobContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Advertisment> Get(object search)
        {
            var query = _context.Advertisment
                .Include(e=>e.Category)
                .Include(e => e.City)
                .Include(e => e.Company)
                .Include(e => e.JobLevel)
                .Include(e => e.JobType)
                .Include(e => e.AdvertismentSkill)
                .AsQueryable();

            return _mapper.Map<List<Model.Advertisment>>(query.ToList());
        }


        public override Model.Advertisment GetById(int id)
        {
            var result = _context.Advertisment
                .Include(e => e.Category)
                .Include(e => e.City)
                .Include(e => e.Company)
                .Include(e => e.JobLevel)
                .Include(e => e.JobType)
                .Include(e => e.AdvertismentSkill)
                .FirstOrDefault(e=>e.AdvertismentId==id);

            return _mapper.Map<Model.Advertisment>(result);

        }
    }
}
