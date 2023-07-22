using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewDashboardTargetDatasource
    {
        public int ServiceProviderId { get; set; }
        public string ServiceProviderDesc { get; set; }
        public string OperatingDistrict { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictDescription { get; set; }
    }
}
