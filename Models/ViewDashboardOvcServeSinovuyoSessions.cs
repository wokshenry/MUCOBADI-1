using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewDashboardOvcServeSinovuyoSessions
    {
        public int? SinoParentingDirectMemberId { get; set; }
        public int? NoSessions { get; set; }
        public string GenderId { get; set; }
        public string GenderDescription { get; set; }
        public DateTime? DoB { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictDescription { get; set; }
        public int? SubcountyId { get; set; }
        public string SubcountyDescription { get; set; }
        public int? ParentingGroupSessionId { get; set; }
        public decimal? GroupSessionCount { get; set; }
        public int Attended80Percent { get; set; }
        public int? ActualAge { get; set; }
        public string AgeCategory { get; set; }
    }
}
