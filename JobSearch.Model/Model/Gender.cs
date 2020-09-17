using System;
using System.Collections.Generic;

namespace JobSearch.WebAPI.Database
{
    public partial class Gender
    {
        public int GenderId { get; set; }
        public string GenderType { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
