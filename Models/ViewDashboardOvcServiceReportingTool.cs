using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewDashboardOvcServiceReportingTool
    {
        public int VisitServiceReportingToolHeaderId { get; set; }
        public int? HouseHoldId { get; set; }
        public string HomeVisitReasonId { get; set; }
        public string HomeVisitReasonOther { get; set; }
        public string HomeVisitorName { get; set; }
        public string VisitorTitle { get; set; }
        public DateTime? VisitationDate { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewerTitle { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string HouseHoldMembersTalkedTo { get; set; }
        public DateTime? DoB { get; set; }
        public string GenderId { get; set; }
        public string GenderDescription { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public string DistrictDescription { get; set; }
        public string SubcountyDescription { get; set; }
        public int? ProgramParticipationId { get; set; }
        public string ProgramParticipationDescription { get; set; }
        public int? ActualAge { get; set; }
        public string AgeCategory { get; set; }
    }
}
