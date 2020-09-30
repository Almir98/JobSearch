using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.ViewModels
{
    public class CityUpsertVM
    {
        public string CityName { get; set; }
        public string ZipCode { get; set; }
        public int? CountryId { get; set; }
    }
}
