using System;
using System.Collections.Generic;

namespace JobSearch.Model
{
    public partial class JobType
    {
        public int JobTypeId { get; set; }
        public string JobTypeName { get; set; }

        public virtual ICollection<Advertisment> Advertisment { get; set; }
    }
}
