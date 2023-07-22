using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class VslaTrackingTool
    {
        public VslaTrackingTool()
        {
            VslaTrackingToolDirectMember = new HashSet<VslaTrackingToolDirectMember>();
            VslaTrackingToolInDirectMember = new HashSet<VslaTrackingToolInDirectMember>();
        }

        public int TrackingToolId { get; set; }
        public int? ImplementingPartnerId { get; set; }
        public int? GroupCompositionCode { get; set; }
        public int? GroupCycleId { get; set; }
        public int? SubcountyId { get; set; }
        public int? ParishId { get; set; }
        public DateTime? GroupFoundation { get; set; }
        public DateTime? CycleSavingStartDate { get; set; }
        public string ReportingMonth { get; set; }
        public int? LinkageToExternalSaving { get; set; }
        public string NameLinkageToExternalSaving { get; set; }
        public int? NoMembersAtStartOfCycle { get; set; }
        public double? CummValueOfSavingsThisCycle { get; set; }
        public double? LoanCashInBoxBank { get; set; }
        public double? CashBalanceInOvcFund { get; set; }
        public int? LinkageToExternalCredit { get; set; }
        public string NameLinkageToExternalCredit { get; set; }
        public int? NoMemberAttendingMeeting { get; set; }
        public double? ValueOfLoanOutStanding { get; set; }
        public double? CashInWelfareFund { get; set; }
        public int? CumulativeNoOvcAccessingTcs { get; set; }
        public double? AmountSavingDepositedToFfi { get; set; }
        public int? NoOfOutstandingLoan { get; set; }
        public double? UnpaidBalanceOfLateLoan { get; set; }
        public double? CummValueOfPropertyNow { get; set; }
        public double? TotalCumulativeCashPayoutOvcFund { get; set; }
        public double? ValeOfOutstandingLoansAtFfi { get; set; }
        public int? NoOfMembersRunningIgas { get; set; }
        public int? NoOfBensTrainedFl { get; set; }
        public int? NoOfBensTrainedSpm { get; set; }
        public int? VslaGroupTrainerId { get; set; }
        public string CollectedBy { get; set; }
        public string CollectedDeignation { get; set; }
        public DateTime? CollectionDate { get; set; }
        public string ReviewedBy { get; set; }
        public string ReviewDesignation { get; set; }
        public DateTime? ReviewDate { get; set; }
        public int? GroupId { get; set; }
        public string GroupCode { get; set; }
        public int? DistrictId { get; set; }

        public virtual ADistrict District { get; set; }
        public virtual AGroups Group { get; set; }
        public virtual VslaGroupComposition GroupCompositionCodeNavigation { get; set; }
        public virtual AGroupCycle GroupCycle { get; set; }
        public virtual AImplementingPartner ImplementingPartner { get; set; }
        public virtual AYesNo LinkageToExternalCreditNavigation { get; set; }
        public virtual AYesNo LinkageToExternalSavingNavigation { get; set; }
        public virtual AVslaGroupTrainer VslaGroupTrainer { get; set; }
        public virtual ICollection<VslaTrackingToolDirectMember> VslaTrackingToolDirectMember { get; set; }
        public virtual ICollection<VslaTrackingToolInDirectMember> VslaTrackingToolInDirectMember { get; set; }
    }
}
