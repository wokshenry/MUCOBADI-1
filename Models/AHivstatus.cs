using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AHivstatus
    {
        public AHivstatus()
        {
            BeneficiaryIdentificationRegister = new HashSet<BeneficiaryIdentificationRegister>();
            HivTbRisKassessmentTool = new HashSet<HivTbRisKassessmentTool>();
            HivTbTrackingForm = new HashSet<HivTbTrackingForm>();
            HouseHoldMembers = new HashSet<HouseHoldMembers>();
            ReferralForm = new HashSet<ReferralForm>();
        }

        public int HivstatusId { get; set; }
        public string HivstatusDescription { get; set; }

        public virtual ICollection<BeneficiaryIdentificationRegister> BeneficiaryIdentificationRegister { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentTool { get; set; }
        public virtual ICollection<HivTbTrackingForm> HivTbTrackingForm { get; set; }
        public virtual ICollection<HouseHoldMembers> HouseHoldMembers { get; set; }
        public virtual ICollection<ReferralForm> ReferralForm { get; set; }
    }
}
