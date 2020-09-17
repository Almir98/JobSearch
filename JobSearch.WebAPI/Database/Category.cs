using System;
using System.Collections.Generic;

namespace JobSearch.WebAPI.Database
{
    public partial class Category
    {
        public Category()
        {
            Advertisment = new HashSet<Advertisment>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Advertisment> Advertisment { get; set; }
    }
}
