using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewSlrHomeVisit
    {
        public int VisitServiceReportingToolDetailId { get; set; }
        public int? HouseHoldId { get; set; }
        public DateTime? VisitationDate { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public int? ProgramParticipationId { get; set; }
    }
}
