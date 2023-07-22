using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class MonthlyCaseTrackingRegister
    {
        public MonthlyCaseTrackingRegister()
        {
            MonthlyCaseTrackingRegisterDetail = new HashSet<MonthlyCaseTrackingRegisterDetail>();
        }

        public int CaseTrackingRegisterId { get; set; }
        public int? ImplementingPartnerId { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public int? HouseHoldId { get; set; }
        public string OfficerName { get; set; }
        public DateTime? DataCollectionDate { get; set; }
        public int? TermId { get; set; }
        public string SubmittedBy { get; set; }
        public string SubmittedTitle { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public string ReviewedBy { get; set; }
        public string ReviewTitle { get; set; }
        public DateTime? ReviewDate { get; set; }

        public virtual ADistrict District { get; set; }
        public virtual BeneficiaryIdentificationRegister HouseHold { get; set; }
        public virtual AImplementingPartner ImplementingPartner { get; set; }
        public virtual ASubcounty Subcounty { get; set; }
        public virtual ATerm Term { get; set; }
        public virtual ICollection<MonthlyCaseTrackingRegisterDetail> MonthlyCaseTrackingRegisterDetail { get; set; }
    }
}
