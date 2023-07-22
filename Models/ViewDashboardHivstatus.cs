using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewDashboardHivstatus
    {
        public int HouseHoldMemberId { get; set; }
        public int? HouseHoldId { get; set; }
        public string Surname { get; set; }
        public string Givenname { get; set; }
        public string GenderId { get; set; }
        public int? HivstatusId { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public int? ParishId { get; set; }
        public int? VillageId { get; set; }
        public string DistrictDescription { get; set; }
        public string SubcountyDescription { get; set; }
    }
}
