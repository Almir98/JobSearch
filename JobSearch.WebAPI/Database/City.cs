using System;
using System.Collections.Generic;

namespace JobSearch.WebAPI.Database
{
    public partial class City
    {
        public City()
        {
            Advertisment = new HashSet<Advertisment>();
            Users = new HashSet<Users>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }
        public string ZipCode { get; set; }
        public int? CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Advertisment> Advertisment { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
