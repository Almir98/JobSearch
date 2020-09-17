using System;
using System.Collections.Generic;

namespace JobSearch.WebAPI.Database
{
    public partial class Users
    {
        public Users()
        {
            Application = new HashSet<Application>();
        }

        public int UserId { get; set; }
        public string TypeName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public DateTime? YearOfBirth { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public int? CityId { get; set; }
        public int? GenderId { get; set; }
        public int? UserTypeId { get; set; }

        public virtual City City { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual UserType UserType { get; set; }
        public virtual ICollection<Application> Application { get; set; }
    }
}
