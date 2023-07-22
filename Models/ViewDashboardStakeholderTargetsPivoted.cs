using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewDashboardStakeholderTargetsPivoted
    {
        public int? IndicatorId { get; set; }
        public string IndicatorDescription { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictDescription { get; set; }
        public int? FinancialYearId { get; set; }
        public string FinancialYearDesc { get; set; }
        public int? ServiceProviderId { get; set; }
        public string ServiceProviderDesc { get; set; }
        public int QuarterOne { get; set; }
        public int QuarterTwo { get; set; }
        public int QuarterThree { get; set; }
        public int QuarterFour { get; set; }
    }
}
