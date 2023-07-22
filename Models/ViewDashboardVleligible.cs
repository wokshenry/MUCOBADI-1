using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewDashboardVleligible
    {
        public int ReferralFormId { get; set; }
        public int? HouseHoldId { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public DateTime? DateofOccurancy { get; set; }
        public int? DateofOccurancyYear { get; set; }
        public int? DateofOccurancyMonth { get; set; }
        public string SplitServicesProvided { get; set; }
        public int? HivstatusId { get; set; }
        public string HivstatusDescription { get; set; }
        public string ServicesProvided { get; set; }
    }
}
