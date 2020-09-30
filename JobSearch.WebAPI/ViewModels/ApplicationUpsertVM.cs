using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.ViewModels
{
    public class ApplicationUpsertVM
    {
        public DateTime ApplicationDate { get; set; }
        public string Description { get; set; }
        public string Cv { get; set; }
        public string Motivation { get; set; }
        public int? AdvertismentId { get; set; }
        public int? UserId { get; set; }
    }
}
