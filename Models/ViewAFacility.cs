using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewAFacility
    {
        public int FacilityId { get; set; }
        public string FacilityName { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictDescription { get; set; }
        public string DistricCode { get; set; }
    }
}
