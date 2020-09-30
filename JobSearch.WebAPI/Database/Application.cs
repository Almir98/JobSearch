using System;
using System.Collections.Generic;

namespace JobSearch.WebAPI.Database
{
    public partial class Application
    {
        public int ApplicationId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string Description { get; set; }
        public string Cv { get; set; }
        public string Motivation { get; set; }
        public int? AdvertismentId { get; set; }
        public int? UserId { get; set; }

        public virtual Advertisment Advertisment { get; set; }
        public virtual Users User { get; set; }
    }
}
