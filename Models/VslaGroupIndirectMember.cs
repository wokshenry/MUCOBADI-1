using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class VslaGroupIndirectMember
    {
        public VslaGroupIndirectMember()
        {
            BeneficiaryLinkageTrackingToolIndirectMember = new HashSet<BeneficiaryLinkageTrackingToolIndirectMember>();
            CommunityTrainingRegisterIndirectMember = new HashSet<CommunityTrainingRegisterIndirectMember>();
            EcdIndirectMemberAttendence = new HashSet<EcdIndirectMemberAttendence>();
            SinoParentingIndirectMemberAttendence = new HashSet<SinoParentingIndirectMemberAttendence>();
            VslaGroupShareOutIndirectMember = new HashSet<VslaGroupShareOutIndirectMember>();
            VslaTrackingToolInDirectMember = new HashSet<VslaTrackingToolInDirectMember>();
        }

        public int VslaGroupIndirectMemberId { get; set; }
        public int? GroupCompositionCode { get; set; }
        public string IndirectMemberCode { get; set; }
        public string MemberName { get; set; }
        public string GenderId { get; set; }
        public int? Age { get; set; }
        public int? ParishId { get; set; }
        public int? VillageId { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? DoB { get; set; }

        public virtual AGender Gender { get; set; }
        public virtual VslaGroupComposition GroupCompositionCodeNavigation { get; set; }
        public virtual AParish Parish { get; set; }
        public virtual AVillage Village { get; set; }
        public virtual ICollection<BeneficiaryLinkageTrackingToolIndirectMember> BeneficiaryLinkageTrackingToolIndirectMember { get; set; }
        public virtual ICollection<CommunityTrainingRegisterIndirectMember> CommunityTrainingRegisterIndirectMember { get; set; }
        public virtual ICollection<EcdIndirectMemberAttendence> EcdIndirectMemberAttendence { get; set; }
        public virtual ICollection<SinoParentingIndirectMemberAttendence> SinoParentingIndirectMemberAttendence { get; set; }
        public virtual ICollection<VslaGroupShareOutIndirectMember> VslaGroupShareOutIndirectMember { get; set; }
        public virtual ICollection<VslaTrackingToolInDirectMember> VslaTrackingToolInDirectMember { get; set; }
    }
}
