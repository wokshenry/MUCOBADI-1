using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AOvcserviceProvider
    {
        public AOvcserviceProvider()
        {
            BeneficiaryEnrolmentRegisterHeader = new HashSet<BeneficiaryEnrolmentRegisterHeader>();
        }

        public int OvcserviceProviderId { get; set; }
        public string OvcserviceProviderName { get; set; }

        public virtual ICollection<BeneficiaryEnrolmentRegisterHeader> BeneficiaryEnrolmentRegisterHeader { get; set; }
    }
}
