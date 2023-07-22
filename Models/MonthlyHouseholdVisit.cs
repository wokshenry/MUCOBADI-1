using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class MonthlyHouseholdVisit
    {
        public int HouseHoldMemberId { get; set; }
        public int? HouseHoldId { get; set; }
        public string HouseHoldCode { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public string HouseHoldMemberCode { get; set; }
        public string MemberName { get; set; }
        public string GenderId { get; set; }
        public string GenderDescription { get; set; }
        public int? Age { get; set; }
        public int IsVisited { get; set; }
    }
}
