using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AGroups
    {
        public AGroups()
        {
            BeneficiaryLinkageTrackingTool = new HashSet<BeneficiaryLinkageTrackingTool>();
            CommunityTrainingRegister = new HashSet<CommunityTrainingRegister>();
            EcdAttendenceRegister = new HashSet<EcdAttendenceRegister>();
            SinoParentingAttendenceRegister = new HashSet<SinoParentingAttendenceRegister>();
            VslaGroupComposition = new HashSet<VslaGroupComposition>();
            VslaGroupShareOutHeader = new HashSet<VslaGroupShareOutHeader>();
            VslaTrackingTool = new HashSet<VslaTrackingTool>();
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; }

        public virtual ICollection<BeneficiaryLinkageTrackingTool> BeneficiaryLinkageTrackingTool { get; set; }
        public virtual ICollection<CommunityTrainingRegister> CommunityTrainingRegister { get; set; }
        public virtual ICollection<EcdAttendenceRegister> EcdAttendenceRegister { get; set; }
        public virtual ICollection<SinoParentingAttendenceRegister> SinoParentingAttendenceRegister { get; set; }
        public virtual ICollection<VslaGroupComposition> VslaGroupComposition { get; set; }
        public virtual ICollection<VslaGroupShareOutHeader> VslaGroupShareOutHeader { get; set; }
        public virtual ICollection<VslaTrackingTool> VslaTrackingTool { get; set; }
    }
}
