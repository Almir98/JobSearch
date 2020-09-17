using System;
using System.Collections.Generic;

namespace JobSearch.Model.Data
{
    public partial class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Advertisment> Advertisment { get; set; }
    }
}
