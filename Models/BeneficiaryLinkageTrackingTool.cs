using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class BeneficiaryLinkageTrackingTool
    {
        public BeneficiaryLinkageTrackingTool()
        {
            BeneficiaryLinkageTrackingToolDirectMember = new HashSet<BeneficiaryLinkageTrackingToolDirectMember>();
            BeneficiaryLinkageTrackingToolIndirectMember = new HashSet<BeneficiaryLinkageTrackingToolIndirectMember>();
        }

        public int LinkageTrackingToolId { get; set; }
        public int? ImplementingPartnerId { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public int? GroupCompositionCode { get; set; }
        public DateTime? LinkageDate { get; set; }
        public int? GroupTypeId { get; set; }
        public string OtherGroupType { get; set; }
        public int? ServiceProviderId { get; set; }
        public int? LinkageServiceCategoryId { get; set; }
        public string PersonProvidingService { get; set; }
        public string TitlePersonProvidingService { get; set; }
        public DateTime? DateProvidingService { get; set; }
        public string SubmittedBy { get; set; }
        public string SubmittedTitle { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public string ReviewedBy { get; set; }
        public string ReviewTitle { get; set; }
        public DateTime? ReviewDate { get; set; }
        public int? GroupId { get; set; }

        public virtual ADistrict District { get; set; }
        public virtual AGroups Group { get; set; }
        public virtual VslaGroupComposition GroupCompositionCodeNavigation { get; set; }
        public virtual AGroupType GroupType { get; set; }
        public virtual AImplementingPartner ImplementingPartner { get; set; }
        public virtual ALinkageServiceCategory LinkageServiceCategory { get; set; }
        public virtual AServiceProvider ServiceProvider { get; set; }
        public virtual ASubcounty Subcounty { get; set; }
        public virtual ICollection<BeneficiaryLinkageTrackingToolDirectMember> BeneficiaryLinkageTrackingToolDirectMember { get; set; }
        public virtual ICollection<BeneficiaryLinkageTrackingToolIndirectMember> BeneficiaryLinkageTrackingToolIndirectMember { get; set; }
    }
}
