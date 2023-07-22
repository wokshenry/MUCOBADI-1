using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewATargets
    {
        public int TargetId { get; set; }
        public double? TargetValue { get; set; }
        public int? DistrictId { get; set; }
        public int? FinancialYearId { get; set; }
        public string DistrictDescription { get; set; }
        public string FinancialYearDesc { get; set; }
    }
}
