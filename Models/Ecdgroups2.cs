using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class Ecdgroups2
    {
        public string GroupName { get; set; }
        public string GroupCode { get; set; }
        public string Date { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public string Parish { get; set; }
        public int? ParishId { get; set; }
        public string MeetingVenue { get; set; }
        public string MeetingTime { get; set; }
        public string HhIndividualCode { get; set; }
        public string Name { get; set; }
        public string SexMF { get; set; }
        public double? Age { get; set; }
        public string Village { get; set; }
        public string Telephone { get; set; }
        public string CheckedBy { get; set; }
        public string VerifiedBy { get; set; }
    }
}
