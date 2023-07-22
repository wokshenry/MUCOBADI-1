using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewDashboardOvcHivStat
    {
        public int VisitServiceReportingToolHeaderId { get; set; }
        public DateTime? VisitationDate { get; set; }
        public int? VisitationMonth { get; set; }
        public int? Qtr { get; set; }
        public int? VisitationYear { get; set; }
        public int HouseHoldMemberId { get; set; }
        public string Stable { get; set; }
        public string Schooled { get; set; }
        public string Safe { get; set; }
        public string Healthy { get; set; }
        public DateTime? DoB { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictDescription { get; set; }
        public int? HivstatusId { get; set; }
        public string HivstatusDescription { get; set; }
    }
}
