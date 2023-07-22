using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class IndicatorTargetValue
    {
        public int StakeHolderValueId { get; set; }
        public int? ServiceProviderId { get; set; }
        public int IndicatorId { get; set; }
        public int? DistrictId { get; set; }
        public int? FinancialYearId { get; set; }
        public int? TargetValue { get; set; }
        public DateTime? DateCaptured { get; set; }
        public bool? DistrictAggregated { get; set; }
        public string CapturedBy { get; set; }
        public int? QuarterId { get; set; }
        public string DistrictsIdMultiselect { get; set; }
        public int? AgeCategoryId { get; set; }

        public virtual AAgeCategory AgeCategory { get; set; }
        public virtual ADistrict District { get; set; }
        public virtual AFinancialYear FinancialYear { get; set; }
        public virtual AIndicators Indicator { get; set; }
        public virtual AQuarter Quarter { get; set; }
        public virtual AServiceProvider ServiceProvider { get; set; }
    }
}
