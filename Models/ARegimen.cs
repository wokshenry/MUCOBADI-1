using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ARegimen
    {
        public ARegimen()
        {
            BeneficiaryIdentificationRegister = new HashSet<BeneficiaryIdentificationRegister>();
            HivTbTrackingForm = new HashSet<HivTbTrackingForm>();
        }

        public int RegimenId { get; set; }
        public string RegimenDescription { get; set; }

        public virtual ICollection<BeneficiaryIdentificationRegister> BeneficiaryIdentificationRegister { get; set; }
        public virtual ICollection<HivTbTrackingForm> HivTbTrackingForm { get; set; }
    }
}
