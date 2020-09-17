using System;
using System.Collections.Generic;

namespace JobSearch.Model.Data
{
    public partial class Application
    {
        public int ApplicationId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public string Cv { get; set; }
        public string Motivation { get; set; }
        public int? AdvertismentId { get; set; }
        public int? UserId { get; set; }

        public virtual Advertisment Advertisment { get; set; }
        public virtual Users User { get; set; }
    }
}
