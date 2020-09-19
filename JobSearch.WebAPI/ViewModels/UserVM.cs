using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.ViewModels
{
    public class UserVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public DateTime? YearOfBirth { get; set; }
        public int? CityId { get; set; }
        public int? GenderId { get; set; }
        public int? UserTypeId { get; set; }
        public string Password { get; set; }
    }
}
