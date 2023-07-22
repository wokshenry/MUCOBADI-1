using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewDashboardStakeholderTargetsOverrall
    {
        public int? ServiceProviderId { get; set; }
        public string ServiceProviderDesc { get; set; }
        public int? IndicatorId { get; set; }
        public string IndicatorDescription { get; set; }
        public int? FinancialYearId { get; set; }
        public string FinancialYearDesc { get; set; }
        public int? QuarterId { get; set; }
        public string QuarterName { get; set; }
        public int? TotalTarget { get; set; }
    }
}
