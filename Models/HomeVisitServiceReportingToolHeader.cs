using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class HomeVisitServiceReportingToolHeader
    {
        public HomeVisitServiceReportingToolHeader()
        {
            HomeVisitServiceReportingToolDetail = new HashSet<HomeVisitServiceReportingToolDetail>();
        }

        public int VisitServiceReportingToolHeaderId { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public int? HouseHoldId { get; set; }
        public string HomeVisitReasonId { get; set; }
        public string HomeVisitReasonOther { get; set; }
        public int? ProgramParticipationId { get; set; }
        public string HomeVisitorName { get; set; }
        public string VisitorTitle { get; set; }
        public DateTime? VisitationDate { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewerTitle { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string HouseHoldMembersTalkedTo { get; set; }
        public double? Longitudde { get; set; }
        public double? Latitudde { get; set; }

        public virtual ADistrict District { get; set; }
        public virtual BeneficiaryIdentificationRegister HouseHold { get; set; }
        public virtual AProgramParticipationStatus ProgramParticipation { get; set; }
        public virtual ASubcounty Subcounty { get; set; }
        public virtual ICollection<HomeVisitServiceReportingToolDetail> HomeVisitServiceReportingToolDetail { get; set; }
    }
}
