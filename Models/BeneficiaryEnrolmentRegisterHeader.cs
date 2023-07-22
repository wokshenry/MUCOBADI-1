using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class BeneficiaryEnrolmentRegisterHeader
    {
        public BeneficiaryEnrolmentRegisterHeader()
        {
            BeneficiaryEnrolmentRegisterDetails = new HashSet<BeneficiaryEnrolmentRegisterDetails>();
        }

        public int EnrolmentRegisterHeaderId { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public int? HouseHoldId { get; set; }
        public DateTime? EnrolmentDate { get; set; }
        public int? OvcserviceProviderId { get; set; }
        public int? ImplementingPartnerId { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public string CollectedBy { get; set; }
        public string CollectedByTele { get; set; }
        public DateTime? CollectedDate { get; set; }
        public string ReviewedBy { get; set; }
        public string ReviewedByTele { get; set; }
        public DateTime? ReviewDate { get; set; }

        public virtual ADistrict District { get; set; }
        public virtual BeneficiaryIdentificationRegister HouseHold { get; set; }
        public virtual HouseHoldMembers HouseHoldMember { get; set; }
        public virtual AImplementingPartner ImplementingPartner { get; set; }
        public virtual AOvcserviceProvider OvcserviceProvider { get; set; }
        public virtual ASubcounty Subcounty { get; set; }
        public virtual ICollection<BeneficiaryEnrolmentRegisterDetails> BeneficiaryEnrolmentRegisterDetails { get; set; }
    }
}
