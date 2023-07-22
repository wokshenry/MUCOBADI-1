using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewVslaTrackingToolDirectMember
    {
        public int VslatrackingToolDirectMemberId { get; set; }
        public int? TrackingToolId { get; set; }
        public int? VslaGroupDirectMemberId { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public string PhoneNumber { get; set; }
        public int? MonthId { get; set; }
        public int? MemberStausId { get; set; }
        public double? SavedLf { get; set; }
        public double? SavedWf { get; set; }
        public double? SavedOf { get; set; }
        public double? BorrowedLf { get; set; }
        public double? BorrowedWf { get; set; }
        public double? RepaidLf { get; set; }
        public double? RepaidWf { get; set; }
        public int? LfReasonForBorrowingId { get; set; }
        public int? WfReasonForBorrowingId { get; set; }
    }
}
