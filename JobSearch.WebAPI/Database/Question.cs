using System;
using System.Collections.Generic;

namespace JobSearch.WebAPI.Database
{
    public partial class Question
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public int? UserId { get; set; }

        public virtual Users User { get; set; }
    }
}
