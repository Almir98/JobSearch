using System;
using System.Collections.Generic;

namespace JobSearch.WebAPI.Database
{
    public partial class Company
    {
        public Company()
        {
            Advertisment = new HashSet<Advertisment>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string AboutUs { get; set; }
        public string Photo { get; set; }
        public string Url { get; set; }

        public virtual ICollection<Advertisment> Advertisment { get; set; }
    }
}
