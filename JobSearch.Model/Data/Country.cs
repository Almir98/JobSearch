using System;
using System.Collections.Generic;

namespace JobSearch.Model.Data
{
    public partial class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<City> City { get; set; }
    }
}
