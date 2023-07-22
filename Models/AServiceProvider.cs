using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AServiceProvider
    {
        public AServiceProvider()
        {
            AContacts = new HashSet<AContacts>();
            BeneficiaryLinkageTrackingTool = new HashSet<BeneficiaryLinkageTrackingTool>();
            BeneficiaryLinkageTrackingToolNew = new HashSet<BeneficiaryLinkageTrackingToolNew>();
            CaseCare = new HashSet<CaseCare>();
            ProjectIndicatorTargetsHeader = new HashSet<ProjectIndicatorTargetsHeader>();
            StakeHolderDataCapture = new HashSet<StakeHolderDataCapture>();
        }

        public int ServiceProviderId { get; set; }
        public string ServiceProviderDesc { get; set; }
        public string OperatingDistrict { get; set; }

        public virtual ICollection<AContacts> AContacts { get; set; }
        public virtual ICollection<BeneficiaryLinkageTrackingTool> BeneficiaryLinkageTrackingTool { get; set; }
        public virtual ICollection<BeneficiaryLinkageTrackingToolNew> BeneficiaryLinkageTrackingToolNew { get; set; }
        public virtual ICollection<CaseCare> CaseCare { get; set; }
        public virtual ICollection<ProjectIndicatorTargetsHeader> ProjectIndicatorTargetsHeader { get; set; }
        public virtual ICollection<StakeHolderDataCapture> StakeHolderDataCapture { get; set; }
    }
}
