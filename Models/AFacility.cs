using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AFacility
    {
        public AFacility()
        {
            AContacts = new HashSet<AContacts>();
            AspNetUsers = new HashSet<AspNetUsers>();
            BeneficiaryIdentificationRegister = new HashSet<BeneficiaryIdentificationRegister>();
            HivTbTrackingForm = new HashSet<HivTbTrackingForm>();
        }

        public int FacilityId { get; set; }
        public string FacilityName { get; set; }
        public int? DistrictId { get; set; }

        public virtual ADistrict District { get; set; }
        public virtual ICollection<AContacts> AContacts { get; set; }
        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
        public virtual ICollection<BeneficiaryIdentificationRegister> BeneficiaryIdentificationRegister { get; set; }
        public virtual ICollection<HivTbTrackingForm> HivTbTrackingForm { get; set; }
    }
}
