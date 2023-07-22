using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AReasonForBorrowingLoan
    {
        public AReasonForBorrowingLoan()
        {
            VslaTrackingToolDirectMemberLfReasonForBorrowing = new HashSet<VslaTrackingToolDirectMember>();
            VslaTrackingToolDirectMemberWfReasonForBorrowing = new HashSet<VslaTrackingToolDirectMember>();
            VslaTrackingToolInDirectMemberLfReasonForBorrowing = new HashSet<VslaTrackingToolInDirectMember>();
            VslaTrackingToolInDirectMemberWfReasonForBorrowing = new HashSet<VslaTrackingToolInDirectMember>();
        }

        public int ReasonForBorrowingId { get; set; }
        public string ReasonForBorrowingDesc { get; set; }

        public virtual ICollection<VslaTrackingToolDirectMember> VslaTrackingToolDirectMemberLfReasonForBorrowing { get; set; }
        public virtual ICollection<VslaTrackingToolDirectMember> VslaTrackingToolDirectMemberWfReasonForBorrowing { get; set; }
        public virtual ICollection<VslaTrackingToolInDirectMember> VslaTrackingToolInDirectMemberLfReasonForBorrowing { get; set; }
        public virtual ICollection<VslaTrackingToolInDirectMember> VslaTrackingToolInDirectMemberWfReasonForBorrowing { get; set; }
    }
}
