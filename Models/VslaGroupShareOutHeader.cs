using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class VslaGroupShareOutHeader
    {
        public VslaGroupShareOutHeader()
        {
            VslaGroupShareOutDirectMember = new HashSet<VslaGroupShareOutDirectMember>();
            VslaGroupShareOutIndirectMember = new HashSet<VslaGroupShareOutIndirectMember>();
        }

        public int VslashareOutHeaderId { get; set; }
        public int? GroupCompositionCode { get; set; }
        public int? GroupCycleId { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public DateTime? CycleSavingStartDate { get; set; }
        public double? TotalDividentPaid { get; set; }
        public double? OldShareValue { get; set; }
        public double? TotalCashAvailableToBeShared { get; set; }
        public DateTime? ShareOutDate { get; set; }
        public string WriteOfThisCycle { get; set; }
        public string Cbtname { get; set; }
        public string ChairPersonName { get; set; }
        public string ChairPersonTele { get; set; }
        public string SecretaryName { get; set; }
        public string SecretaryTele { get; set; }
        public string TreasurerName { get; set; }
        public string TreasurerTele { get; set; }
        public int? GroupId { get; set; }
        public string GroupCode { get; set; }

        public virtual ADistrict District { get; set; }
        public virtual AGroups Group { get; set; }
        public virtual VslaGroupComposition GroupCompositionCodeNavigation { get; set; }
        public virtual AGroupCycle GroupCycle { get; set; }
        public virtual ASubcounty Subcounty { get; set; }
        public virtual ICollection<VslaGroupShareOutDirectMember> VslaGroupShareOutDirectMember { get; set; }
        public virtual ICollection<VslaGroupShareOutIndirectMember> VslaGroupShareOutIndirectMember { get; set; }
    }
}
