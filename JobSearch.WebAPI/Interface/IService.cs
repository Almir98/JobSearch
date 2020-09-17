using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.Interface
{
    public interface IService<TModel,Tsearch>
    {
        List<TModel> Get(Tsearch search);
        TModel GetById(int id);
        void Delete(int id);
    }
}
