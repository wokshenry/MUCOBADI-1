using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class StakeHolderDataCapture
    {
        public int StakeHolderValueId { get; set; }
        public int? ServiceProviderId { get; set; }
        public int? IndicatorId { get; set; }
        public int? DistrictId { get; set; }
        public int? FinancialYearId { get; set; }
        public int? QuarterId { get; set; }
        public int? Lessthan1YearMale { get; set; }
        public int? Lessthan1YearFemale { get; set; }
        public int? OnetoFourYearsMale { get; set; }
        public int? OnetoFourYearsFemale { get; set; }
        public int? FivetoNineYearsMale { get; set; }
        public int? FivetoNineYearsFemale { get; set; }
        public int? TentoFourteenYearsMale { get; set; }
        public int? TentoFourteenYearsFemale { get; set; }
        public int? FifteentoSeventeenYearsMale { get; set; }
        public int? FifteentoSeventeenYearsFemale { get; set; }
        public int? EighteentoTwentyFourYearsMale { get; set; }
        public int? EighteentoTwentyFourYearsFemale { get; set; }
        public int? TwentyFiveAboveYearsMale { get; set; }
        public int? TwentyFiveAboveYearsFemale { get; set; }
        public DateTime? DateCaptured { get; set; }
        public string CapturedBy { get; set; }

        public virtual ADistrict District { get; set; }
        public virtual AFinancialYear FinancialYear { get; set; }
        public virtual AIndicators Indicator { get; set; }
        public virtual AQuarter Quarter { get; set; }
        public virtual AServiceProvider ServiceProvider { get; set; }
    }
}
