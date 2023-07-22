using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AGroupType
    {
        public AGroupType()
        {
            BeneficiaryLinkageTrackingTool = new HashSet<BeneficiaryLinkageTrackingTool>();
            VslaGroupComposition = new HashSet<VslaGroupComposition>();
        }

        public int GroupTypeId { get; set; }
        public string GroupTypeDesc { get; set; }

        public virtual ICollection<BeneficiaryLinkageTrackingTool> BeneficiaryLinkageTrackingTool { get; set; }
        public virtual ICollection<VslaGroupComposition> VslaGroupComposition { get; set; }
    }
}
