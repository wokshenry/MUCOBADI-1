using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class HomeVisitServiceReportingToolDetail
    {
        public int VisitServiceReportingToolDetailId { get; set; }
        public int? VisitServiceReportingToolHeaderId { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public int? ProgramParticipationId { get; set; }
        public string Stable { get; set; }
        public string StableOther { get; set; }
        public string Schooled { get; set; }
        public string SchooledOther { get; set; }
        public string Safe { get; set; }
        public string SafeOther { get; set; }
        public string Healthy { get; set; }
        public string HealthyOther { get; set; }
        public string GapNeededStable { get; set; }
        public string GapNeededSchooled { get; set; }
        public string GapNeededSafe { get; set; }
        public string GapNeededHealthy { get; set; }
        public string EmergingNeedStable { get; set; }
        public string EmergingNeedSchooled { get; set; }
        public string EmergingNeedSafe { get; set; }
        public string EmergingNeedHealthy { get; set; }
        public string UnmetNeedStable { get; set; }
        public string UnmetNeedSchooled { get; set; }
        public string UnmetNeedSafe { get; set; }
        public string UnmetNeedHealthy { get; set; }
        public string IssuesIdentified { get; set; }

        public virtual HouseHoldMembers HouseHoldMember { get; set; }
        public virtual AProgramParticipationStatus ProgramParticipation { get; set; }
        public virtual HomeVisitServiceReportingToolHeader VisitServiceReportingToolHeader { get; set; }
    }
}
