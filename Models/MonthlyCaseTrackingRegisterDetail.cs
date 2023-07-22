using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class MonthlyCaseTrackingRegisterDetail
    {
        public int CaseTrackingRegisterDetailId { get; set; }
        public int? CaseTrackingRegisterId { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public int? VillageId { get; set; }
        public string SexualCaseCategoryItemId { get; set; }
        public string PhysicalCaseCategoryItemId { get; set; }
        public string NeglectCaseCategoryItemId { get; set; }
        public string EmotionalCaseCategoryItemId { get; set; }
        public string OtherFormsCaseCategoryItemId { get; set; }
        public string HivrelatedCaseCategoryItemId { get; set; }
        public int? Referred { get; set; }
        public int? Resolved { get; set; }
        public int? Pending { get; set; }
        public int? Transferred { get; set; }
        public string StableServiceProvided { get; set; }
        public string SchooledServiceProvided { get; set; }
        public string SafeServiceProvided { get; set; }
        public string HealthServiceProvided { get; set; }

        public virtual MonthlyCaseTrackingRegister CaseTrackingRegister { get; set; }
        public virtual HouseHoldMembers HouseHoldMember { get; set; }
        public virtual AYesNo PendingNavigation { get; set; }
        public virtual AYesNo ReferredNavigation { get; set; }
        public virtual AYesNo ResolvedNavigation { get; set; }
        public virtual AYesNo TransferredNavigation { get; set; }
        public virtual AVillage Village { get; set; }
    }
}
