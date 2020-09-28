using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearch.WebAPI.ViewModels
{
    public class QuestionUpsert
    {
        public int? UserId { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
