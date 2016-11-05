using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrayerRequestsApp.Models
{
    public class PrayerRequest
    {
        public int prayerRequestId { get; set; }
        public string prayerRequestText { get; set; }
        public string submittedBy { get; set; }
        public DateTime updatedDate { get; set; }
        public string isAnswered { get; set; }

    }
}