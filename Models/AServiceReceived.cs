using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AServiceReceived
    {
        public AServiceReceived()
        {
            BeneficiaryLinkageTrackingToolNew = new HashSet<BeneficiaryLinkageTrackingToolNew>();
        }

        public int ServiceReceivedId { get; set; }
        public int ServiceCategoryId { get; set; }
        public string ServiceClassiffication { get; set; }
        public string ServiceReceivedDesc { get; set; }

        public virtual AServiceCategory ServiceCategory { get; set; }
        public virtual ICollection<BeneficiaryLinkageTrackingToolNew> BeneficiaryLinkageTrackingToolNew { get; set; }
    }
}
