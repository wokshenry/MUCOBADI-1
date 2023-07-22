using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewASubcounty
    {
        public int SubcountyId { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictDescription { get; set; }
        public string DistricCode { get; set; }
        public string SubcountyDescription { get; set; }
        public string SubCountyCode { get; set; }
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }
    }
}
