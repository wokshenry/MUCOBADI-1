using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class CaseCare
    {
        public CaseCare()
        {
            CaseCareDetail = new HashSet<CaseCareDetail>();
            CaseCareSummary = new HashSet<CaseCareSummary>();
        }

        public int CaseCareId { get; set; }
        public int? ImplementingPartnerId { get; set; }
        public int? ServiceProviderId { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public int? HouseHoldId { get; set; }
        public int? NoMale18Above { get; set; }
        public int? NoFemale18Above { get; set; }
        public int? NoMale18Below { get; set; }
        public int? NoFemale18Below { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public string HouseHoldPhoneNumber { get; set; }
        public string AdministeringPersonName { get; set; }
        public string AdministeringPersonTitle { get; set; }
        public string AdministeringPersonPhoneNumber { get; set; }
        public DateTime? AdministeringDate { get; set; }
        public string InstitutionPriorityAreaCodeId { get; set; }
        public string AssessedBy { get; set; }
        public DateTime? AssessedDate { get; set; }

        public virtual ADistrict District { get; set; }
        public virtual BeneficiaryIdentificationRegister HouseHold { get; set; }
        public virtual HouseHoldMembers HouseHoldMember { get; set; }
        public virtual AImplementingPartner ImplementingPartner { get; set; }
        public virtual AServiceProvider ServiceProvider { get; set; }
        public virtual ASubcounty Subcounty { get; set; }
        public virtual ICollection<CaseCareDetail> CaseCareDetail { get; set; }
        public virtual ICollection<CaseCareSummary> CaseCareSummary { get; set; }
    }
}
