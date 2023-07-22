using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewVslaGroupIndirectMember
    {
        public int GroupCompositionCode { get; set; }
        public string GroupCode { get; set; }
        public int? GroupId { get; set; }
        public int? GroupCycleId { get; set; }
        public DateTime? MeetingDate { get; set; }
        public int? SubcountyId { get; set; }
        public int? ParishId { get; set; }
        public string MeetingVenue { get; set; }
        public DateTime? MeetingTime { get; set; }
        public string OfficerIncharge { get; set; }
        public string Cbtcode { get; set; }
        public string CheckedBy { get; set; }
        public string CheckerPosition { get; set; }
        public DateTime? DateChecked { get; set; }
        public string VerifiedBy { get; set; }
        public string VerifierPosition { get; set; }
        public DateTime? DateofVerification { get; set; }
        public int? GroupTypeId { get; set; }
        public int? DistrictId { get; set; }
        public int VslaGroupIndirectMemberId { get; set; }
        public string IndirectMemberCode { get; set; }
        public string MemberName { get; set; }
        public string GenderId { get; set; }
        public int? Age { get; set; }
        public int? Expr1 { get; set; }
        public int? VillageId { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? DoB { get; set; }
    }
}
