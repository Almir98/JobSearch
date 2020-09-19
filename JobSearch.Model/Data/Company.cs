using System;
using System.Collections.Generic;

namespace JobSearch.Model
{
    public partial class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string AboutUs { get; set; }
        public string Photo { get; set; }

        public virtual ICollection<Advertisment> Advertisment { get; set; }
    }
}
