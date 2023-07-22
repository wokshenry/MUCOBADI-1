using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AKnownRiskFactors
    {
        public AKnownRiskFactors()
        {
            BeneficiaryIdentificationRegister = new HashSet<BeneficiaryIdentificationRegister>();
            HouseHoldMembers = new HashSet<HouseHoldMembers>();
        }

        public int KnownRiskFactorId { get; set; }
        public string KnownRiskFactorDescription { get; set; }

        public virtual ICollection<BeneficiaryIdentificationRegister> BeneficiaryIdentificationRegister { get; set; }
        public virtual ICollection<HouseHoldMembers> HouseHoldMembers { get; set; }
    }
}
