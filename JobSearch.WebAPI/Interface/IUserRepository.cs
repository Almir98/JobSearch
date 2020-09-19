using JobSearch.WebAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.Interface
{
    public interface IUserRepository
    {
        Model.Users Register(UserVM user, string password);
        Model.Users Login(string email,string password);
        public bool UserExist(string email);
    }
}
