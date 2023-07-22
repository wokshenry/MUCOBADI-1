using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewDashboardOvcHivStat2023
    {
        public int? HouseHoldMemberId { get; set; }
        public DateTime? VisitationDate { get; set; }
        public int? VisitationYear { get; set; }
        public int? VisitationMonth { get; set; }
        public int? Qtr { get; set; }
        public int ProgramParticipationId { get; set; }
        public int? HivstatusId { get; set; }
        public int? ActualAge { get; set; }
        public string AgeCategory { get; set; }
        public int? IsCareGiver { get; set; }
        public string HivstatusDescription { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictDescription { get; set; }
    }
}
