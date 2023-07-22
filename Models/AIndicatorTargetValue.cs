using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AIndicatorTargetValue
    {
        public int StakeHolderValueId { get; set; }
        public int? ServiceProviderId { get; set; }
        public int IndicatorId { get; set; }
        public int? DistrictId { get; set; }
        public int? FinancialYearId { get; set; }
        public int? TargetValue { get; set; }
        public string DateCaptured { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }

        public virtual ADistrict District { get; set; }
        public virtual AFinancialYear FinancialYear { get; set; }
        public virtual AIndicators Indicator { get; set; }
        public virtual AServiceProvider ServiceProvider { get; set; }
    }
}
