using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewDashboardStakeholderTargets
    {
        public int StakeHolderValueId { get; set; }
        public int? ServiceProviderId { get; set; }
        public int? IndicatorId { get; set; }
        public int? DistrictId { get; set; }
        public int? FinancialYearId { get; set; }
        public int? QuarterId { get; set; }
        public int? TotalTarget { get; set; }
        public DateTime? DateCaptured { get; set; }
        public string CapturedBy { get; set; }
        public string IndicatorDescription { get; set; }
        public string ServiceProviderDesc { get; set; }
        public string DistrictDescription { get; set; }
        public string FinancialYearDesc { get; set; }
        public string QuarterName { get; set; }
    }
}
