using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewGroupComposition
    {
        public int GroupCompositionCode { get; set; }
        public string GroupCode { get; set; }
        public int? GroupId { get; set; }
        public string GroupName { get; set; }
        public int? GroupCycleId { get; set; }
        public string GroupCycleDesc { get; set; }
        public int? SubcountyId { get; set; }
        public int? ParishId { get; set; }
        public int? GroupTypeId { get; set; }
        public string GroupTypeDesc { get; set; }
    }
}
