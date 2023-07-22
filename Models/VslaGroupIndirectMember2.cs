using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class VslaGroupIndirectMember2
    {
        public int VslaGroupIndirectMemberId { get; set; }
        public int GroupCompositionCode { get; set; }
        public string IndirectMemberCode { get; set; }
        public string MemberName { get; set; }
        public string GenderId { get; set; }
        public int? Age { get; set; }
        public int? ParishId { get; set; }
        public int? VillageId { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? DoB { get; set; }
    }
}
