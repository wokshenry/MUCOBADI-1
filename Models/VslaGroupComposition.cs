using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class VslaGroupComposition
    {
        public VslaGroupComposition()
        {
            BeneficiaryLinkageTrackingTool = new HashSet<BeneficiaryLinkageTrackingTool>();
            CommunityTrainingRegister = new HashSet<CommunityTrainingRegister>();
            EcdAttendenceRegister = new HashSet<EcdAttendenceRegister>();
            SinoParentingAttendenceRegister = new HashSet<SinoParentingAttendenceRegister>();
            VslaGroupCommittee = new HashSet<VslaGroupCommittee>();
            VslaGroupDirectMembers = new HashSet<VslaGroupDirectMembers>();
            VslaGroupIndirectMember = new HashSet<VslaGroupIndirectMember>();
            VslaGroupShareOutHeader = new HashSet<VslaGroupShareOutHeader>();
            VslaTrackingTool = new HashSet<VslaTrackingTool>();
        }

        public int GroupCompositionCode { get; set; }
        public string GroupCode { get; set; }
        public int? GroupId { get; set; }
        public int? GroupCycleId { get; set; }
        public DateTime? MeetingDate { get; set; }
        public int? SubcountyId { get; set; }
        public int? ParishId { get; set; }
        public string MeetingVenue { get; set; }
        public DateTime? MeetingTime { get; set; }
        public string OfficerIncharge { get; set; }
        public string Cbtcode { get; set; }
        public string CheckedBy { get; set; }
        public string CheckerPosition { get; set; }
        public DateTime? DateChecked { get; set; }
        public string VerifiedBy { get; set; }
        public string VerifierPosition { get; set; }
        public DateTime? DateofVerification { get; set; }
        public int? GroupTypeId { get; set; }
        public int? DistrictId { get; set; }

        public virtual ADistrict District { get; set; }
        public virtual AGroups Group { get; set; }
        public virtual AGroupCycle GroupCycle { get; set; }
        public virtual AGroupType GroupType { get; set; }
        public virtual AParish Parish { get; set; }
        public virtual ASubcounty Subcounty { get; set; }
        public virtual ICollection<BeneficiaryLinkageTrackingTool> BeneficiaryLinkageTrackingTool { get; set; }
        public virtual ICollection<CommunityTrainingRegister> CommunityTrainingRegister { get; set; }
        public virtual ICollection<EcdAttendenceRegister> EcdAttendenceRegister { get; set; }
        public virtual ICollection<SinoParentingAttendenceRegister> SinoParentingAttendenceRegister { get; set; }
        public virtual ICollection<VslaGroupCommittee> VslaGroupCommittee { get; set; }
        public virtual ICollection<VslaGroupDirectMembers> VslaGroupDirectMembers { get; set; }
        public virtual ICollection<VslaGroupIndirectMember> VslaGroupIndirectMember { get; set; }
        public virtual ICollection<VslaGroupShareOutHeader> VslaGroupShareOutHeader { get; set; }
        public virtual ICollection<VslaTrackingTool> VslaTrackingTool { get; set; }
    }
}
