using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewDashboardHouseHoldNoVisits
    {
        public int? HouseHoldId { get; set; }
        public int? VisitationYear { get; set; }
        public string Qtr { get; set; }
        public int? NoofVisits { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictDescription { get; set; }
        public int? SubcountyId { get; set; }
        public string SubcountyDescription { get; set; }
    }
}
