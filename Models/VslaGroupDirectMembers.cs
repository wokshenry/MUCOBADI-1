using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class VslaGroupDirectMembers
    {
        public VslaGroupDirectMembers()
        {
            BeneficiaryLinkageTrackingToolDirectMember = new HashSet<BeneficiaryLinkageTrackingToolDirectMember>();
            CommunityTrainingRegisterDirectMember = new HashSet<CommunityTrainingRegisterDirectMember>();
            EcdDirectMemberAttendence = new HashSet<EcdDirectMemberAttendence>();
            SinoParentingDirectMemberAttendence = new HashSet<SinoParentingDirectMemberAttendence>();
            VslaGroupShareOutDirectMember = new HashSet<VslaGroupShareOutDirectMember>();
            VslaTrackingToolDirectMember = new HashSet<VslaTrackingToolDirectMember>();
        }

        public int VslaGroupDirectMemberId { get; set; }
        public int? GroupCompositionCode { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public string PhoneNumber { get; set; }

        public virtual VslaGroupComposition GroupCompositionCodeNavigation { get; set; }
        public virtual HouseHoldMembers HouseHoldMember { get; set; }
        public virtual ICollection<BeneficiaryLinkageTrackingToolDirectMember> BeneficiaryLinkageTrackingToolDirectMember { get; set; }
        public virtual ICollection<CommunityTrainingRegisterDirectMember> CommunityTrainingRegisterDirectMember { get; set; }
        public virtual ICollection<EcdDirectMemberAttendence> EcdDirectMemberAttendence { get; set; }
        public virtual ICollection<SinoParentingDirectMemberAttendence> SinoParentingDirectMemberAttendence { get; set; }
        public virtual ICollection<VslaGroupShareOutDirectMember> VslaGroupShareOutDirectMember { get; set; }
        public virtual ICollection<VslaTrackingToolDirectMember> VslaTrackingToolDirectMember { get; set; }
    }
}
