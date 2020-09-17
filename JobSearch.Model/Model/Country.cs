using System;
using System.Collections.Generic;

namespace JobSearch.WebAPI.Database
{
    public partial class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<City> City { get; set; }
    }
}
