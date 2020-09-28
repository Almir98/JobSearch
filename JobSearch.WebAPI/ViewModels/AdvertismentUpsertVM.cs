using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.ViewModels
{
    public class AdvertismentUpsertVM
    {
        public string CategoryName { get; set; }
        public DateTime Published { get; set; }
        public DateTime ToDate { get; set; }
        public bool IsActive { get; set; }
        public string Requirements { get; set; }
        public string BonusSkills { get; set; }
        public string Offers { get; set; }
        public string Education { get; set; }
        public string JobDescription { get; set; }
        public string CandidateDescription { get; set; }
        public int? CityId { get; set; }
        public int? CompanyId { get; set; }
        public int? CategoryId { get; set; }
        public int? JobLevelId { get; set; }
        public int? JobTypeId { get; set; }
    }
}
