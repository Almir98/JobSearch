using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.ViewModels
{
    public class CompanyUpsertVM
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string AboutUs { get; set; }
        public string Photo { get; set; }
    }
}
