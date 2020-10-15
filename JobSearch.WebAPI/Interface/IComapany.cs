using JobSearch.WebAPI.ViewModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.Interface
{
    public interface IComapany
    {
        List<Model.Company> GetAll();
        Model.Company GetById(int id);
        Model.Company Insert(CompanyUpsertVM request, IFormFile file);
    }
}
