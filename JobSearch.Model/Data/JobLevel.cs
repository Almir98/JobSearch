using System;
using System.Collections.Generic;

namespace JobSearch.Model
{
    public partial class JobLevel
    {
        public int JobLevelId { get; set; }
        public string LevelName { get; set; }

        public virtual ICollection<Advertisment> Advertisment { get; set; }
    }
}
