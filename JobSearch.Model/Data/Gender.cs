using System;
using System.Collections.Generic;

namespace JobSearch.Model.Data
{
    public partial class Gender
    {
        public int GenderId { get; set; }
        public string GenderType { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
