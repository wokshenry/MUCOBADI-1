using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AGroupCycle
    {
        public AGroupCycle()
        {
            CommunityTrainingRegister = new HashSet<CommunityTrainingRegister>();
            VslaGroupComposition = new HashSet<VslaGroupComposition>();
            VslaGroupShareOutHeader = new HashSet<VslaGroupShareOutHeader>();
            VslaTrackingTool = new HashSet<VslaTrackingTool>();
        }

        public int GroupCycleId { get; set; }
        public string GroupCycleDesc { get; set; }

        public virtual ICollection<CommunityTrainingRegister> CommunityTrainingRegister { get; set; }
        public virtual ICollection<VslaGroupComposition> VslaGroupComposition { get; set; }
        public virtual ICollection<VslaGroupShareOutHeader> VslaGroupShareOutHeader { get; set; }
        public virtual ICollection<VslaTrackingTool> VslaTrackingTool { get; set; }
    }
}
