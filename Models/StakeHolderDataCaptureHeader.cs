using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class StakeHolderDataCaptureHeader
    {
        public StakeHolderDataCaptureHeader()
        {
            StakeHolderDataCapture = new HashSet<StakeHolderDataCapture>();
        }

        public int StakeHolderHeaderValueId { get; set; }
        public int? FinancialYearId { get; set; }
        public int? ServiceProviderId { get; set; }
        public int? IndicatorId { get; set; }

        public virtual AFinancialYear FinancialYear { get; set; }
        public virtual AIndicators Indicator { get; set; }
        public virtual AServiceProvider ServiceProvider { get; set; }
        public virtual ICollection<StakeHolderDataCapture> StakeHolderDataCapture { get; set; }
    }
}
