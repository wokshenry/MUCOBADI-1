using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewVslaGroupDirectMembers
    {
        public int GroupCompositionCode { get; set; }
        public string GroupCode { get; set; }
        public int? GroupId { get; set; }
        public int? GroupCycleId { get; set; }
        public int VslaGroupDirectMemberId { get; set; }
        public int? HouseHoldId { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public string HouseHoldMemberCode { get; set; }
        public string Surname { get; set; }
        public string Givenname { get; set; }
        public string GenderId { get; set; }
        public string GenderDescription { get; set; }
        public DateTime? DoB { get; set; }
        public int? Age { get; set; }
        public int? KnownRiskFactorId { get; set; }
        public string KnownRiskFactorDescription { get; set; }
        public int? HivstatusId { get; set; }
        public string HivstatusDescription { get; set; }
        public string HouseHoldCode { get; set; }
        public int? SubcountyId { get; set; }
        public int? GroupTypeId { get; set; }
        public int? DistrictId { get; set; }
    }
}
