using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AProgramParticipationStatus
    {
        public AProgramParticipationStatus()
        {
            HomeVisitServiceReportingToolDetail = new HashSet<HomeVisitServiceReportingToolDetail>();
            HomeVisitServiceReportingToolHeader = new HashSet<HomeVisitServiceReportingToolHeader>();
            HouseHoldMembers = new HashSet<HouseHoldMembers>();
        }

        public int ProgramParticipationId { get; set; }
        public string ProgramParticipationDescription { get; set; }

        public virtual ICollection<HomeVisitServiceReportingToolDetail> HomeVisitServiceReportingToolDetail { get; set; }
        public virtual ICollection<HomeVisitServiceReportingToolHeader> HomeVisitServiceReportingToolHeader { get; set; }
        public virtual ICollection<HouseHoldMembers> HouseHoldMembers { get; set; }
    }
}
