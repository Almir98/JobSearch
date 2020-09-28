using AutoMapper;
using JobSearch.WebAPI.Database;
using JobSearch.WebAPI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.Service
{
    public class BaseService<TModel, Tsearch, TDatabase> : IService<TModel, Tsearch> where TDatabase:class
    {
        protected readonly SearchJobContext _context;
        protected readonly IMapper _mapper;

        public BaseService(SearchJobContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual List<TModel> Get(Tsearch search)
        {
            return _mapper.Map<List<TModel>>(_context.Set<TDatabase>().ToList());
        }

        public virtual TModel GetById(int id)
        {
            return _mapper.Map<TModel>(_context.Set<TDatabase>().Find(id));
        }
        
        public void Delete(int id)
        {
            var result = _context.Set<TDatabase>().Find(id);
            if(result==null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                _context.Set<TDatabase>().Remove(result);
                _context.SaveChanges();
            }
        }
    }
}
