using System;
using System.Collections.Generic;

namespace JobSearch.Model
{
    public partial class AdvertismentSkill
    {
        public int AdvertismentSkillId { get; set; }
        public int? AdvertismentId { get; set; }
        public int? SkillId { get; set; }

        public virtual Advertisment Advertisment { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
