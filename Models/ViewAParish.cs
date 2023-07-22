using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewAParish
    {
        public string RegionDescription { get; set; }
        public string DistrictDescription { get; set; }
        public string SubcountyDescription { get; set; }
        public int ParishId { get; set; }
        public int? SubcountyId { get; set; }
        public string ParishDescription { get; set; }
        public int? DistrictId { get; set; }
        public int RegionId { get; set; }
    }
}
