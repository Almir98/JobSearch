using System;
using System.Collections.Generic;

namespace JobSearch.WebAPI.Database
{
    public partial class UserType
    {
        public int UserTypeId { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
