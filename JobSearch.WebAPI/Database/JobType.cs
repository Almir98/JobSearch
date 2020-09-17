using System;
using System.Collections.Generic;

namespace JobSearch.WebAPI.Database
{
    public partial class JobType
    {
        public JobType()
        {
            Advertisment = new HashSet<Advertisment>();
        }

        public int JobTypeId { get; set; }
        public string JobTypeName { get; set; }

        public virtual ICollection<Advertisment> Advertisment { get; set; }
    }
}
