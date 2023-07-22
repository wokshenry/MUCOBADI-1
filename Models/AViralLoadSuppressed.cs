using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AViralLoadSuppressed
    {
        public AViralLoadSuppressed()
        {
            BeneficiaryIdentificationRegister = new HashSet<BeneficiaryIdentificationRegister>();
            HivTbTrackingForm = new HashSet<HivTbTrackingForm>();
        }

        public int ViralLoadSuppressedId { get; set; }
        public string ViralLoadSuppressedDescription { get; set; }

        public virtual ICollection<BeneficiaryIdentificationRegister> BeneficiaryIdentificationRegister { get; set; }
        public virtual ICollection<HivTbTrackingForm> HivTbTrackingForm { get; set; }
    }
}
