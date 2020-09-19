using System;
using System.Collections.Generic;

namespace JobSearch.Model
{
    public partial class Advertisment
    {
        public int AdvertismentId { get; set; }
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

        public virtual Category Category { get; set; }
        public virtual City City { get; set; }
        public virtual Company Company { get; set; }
        public virtual JobLevel JobLevel { get; set; }
        public virtual JobType JobType { get; set; }
        public virtual ICollection<AdvertismentSkill> AdvertismentSkill { get; set; }
        public virtual ICollection<Application> Application { get; set; }
    }
}
