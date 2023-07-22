using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewAdminUnits
    {
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }
        public int DistrictId { get; set; }
        public string DistrictDescription { get; set; }
        public int SubcountyId { get; set; }
        public string SubcountyDescription { get; set; }
    }
}
