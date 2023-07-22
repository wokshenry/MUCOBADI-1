using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ALinkageServiceCategory
    {
        public ALinkageServiceCategory()
        {
            AServiceLinkedTo = new HashSet<AServiceLinkedTo>();
            BeneficiaryLinkageTrackingTool = new HashSet<BeneficiaryLinkageTrackingTool>();
            BeneficiaryLinkageTrackingToolNew = new HashSet<BeneficiaryLinkageTrackingToolNew>();
        }

        public int LinkageServiceCategoryId { get; set; }
        public string LinkageServiceCategoryDesc { get; set; }

        public virtual ICollection<AServiceLinkedTo> AServiceLinkedTo { get; set; }
        public virtual ICollection<BeneficiaryLinkageTrackingTool> BeneficiaryLinkageTrackingTool { get; set; }
        public virtual ICollection<BeneficiaryLinkageTrackingToolNew> BeneficiaryLinkageTrackingToolNew { get; set; }
    }
}
