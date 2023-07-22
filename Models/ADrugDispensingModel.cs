using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ADrugDispensingModel
    {
        public ADrugDispensingModel()
        {
            BeneficiaryIdentificationRegister = new HashSet<BeneficiaryIdentificationRegister>();
        }

        public int DispensingModelId { get; set; }
        public string DispensingModelDescription { get; set; }

        public virtual ICollection<BeneficiaryIdentificationRegister> BeneficiaryIdentificationRegister { get; set; }
    }
}
