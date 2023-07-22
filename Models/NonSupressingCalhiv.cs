using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class NonSupressingCalhiv
    {
        public int? HouseHoldMemberId { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public int? HouseHoldId { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public string HouseHoldCode { get; set; }
        public string HouseHoldMemberCode { get; set; }
        public string MemberName { get; set; }
        public int? Age { get; set; }
        public int? KnownRiskFactorId { get; set; }
        public string ViralloadTestResults { get; set; }
    }
}
