using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewProjectIndicatorTargetsHeader
    {
        public int ProjectTargetValueHeaderId { get; set; }
        public int? ServiceProviderId { get; set; }
        public int? FinancialYearId { get; set; }
        public int? IndicatorId { get; set; }
        public string CapturedBy { get; set; }
        public DateTime? DateCaptured { get; set; }
        public int IndicatorTargetValueId { get; set; }
        public int? DistrictId { get; set; }
        public double? TargetValue { get; set; }
        public string IndicatorDescription { get; set; }
        public string DistrictDescription { get; set; }
        public string FinancialYearDesc { get; set; }
    }
}
