using AutoMapper;
using JobSearch.WebAPI.Database;
using JobSearch.WebAPI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.Service
{
    public class BaseCRUDService<TModel, TSerch, TDatabase, TInsert, TUpdate> : BaseService<TModel, TSerch, TDatabase>, ICRUDService<TModel, TSerch, TInsert, TUpdate> where TDatabase : class
    {
        public BaseCRUDService(SearchJobContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public virtual TModel Insert(TInsert request)
        {
            var entity = _mapper.Map<TDatabase>(request);

            _context.Set<TDatabase>().Add(entity);
            _context.SaveChanges();
            return _mapper.Map<TModel>(entity);
        }

        public virtual TModel Update(int id, TUpdate request)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            _context.Set<TDatabase>().Attach(entity);
            _context.Set<TDatabase>().Update(entity);

            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<TModel>(entity);
        }
    }
}
