using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AOvcVlrAndOvcVls
    {
        public AOvcVlrAndOvcVls()
        {
            BeneficiaryIdentificationRegister = new HashSet<BeneficiaryIdentificationRegister>();
        }

        public int OvcVlrId { get; set; }
        public string OvcVlrDescription { get; set; }

        public virtual ICollection<BeneficiaryIdentificationRegister> BeneficiaryIdentificationRegister { get; set; }
    }
}
