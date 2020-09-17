using System;
using System.Collections.Generic;

namespace JobSearch.WebAPI.Database
{
    public partial class Skill
    {
        public Skill()
        {
            AdvertismentSkill = new HashSet<AdvertismentSkill>();
        }

        public int SkillId { get; set; }
        public string SkillName { get; set; }

        public virtual ICollection<AdvertismentSkill> AdvertismentSkill { get; set; }
    }
}
