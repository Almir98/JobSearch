﻿using System;
using System.Collections.Generic;

namespace JobSearch.WebAPI.Database
{
    public partial class JobLevel
    {
        public JobLevel()
        {
            Advertisment = new HashSet<Advertisment>();
        }

        public int JobLevelId { get; set; }
        public string LevelName { get; set; }

        public virtual ICollection<Advertisment> Advertisment { get; set; }
    }
}
