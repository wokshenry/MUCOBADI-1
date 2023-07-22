using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ARegimenCategory
    {
        public ARegimenCategory()
        {
            BeneficiaryIdentificationRegister = new HashSet<BeneficiaryIdentificationRegister>();
            HivTbTrackingForm = new HashSet<HivTbTrackingForm>();
        }

        public int RegimenCategoryId { get; set; }
        public string RegimenCategoryDescription { get; set; }

        public virtual ICollection<BeneficiaryIdentificationRegister> BeneficiaryIdentificationRegister { get; set; }
        public virtual ICollection<HivTbTrackingForm> HivTbTrackingForm { get; set; }
    }
}
