using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ATargetsLog
    {
        public int TargetsLogId { get; set; }
        public int? TargetId { get; set; }
        public double? TargetValueOld { get; set; }
        public double? TargetValueNew { get; set; }
        public int? DistrictIdOld { get; set; }
        public int? DistrictIdNew { get; set; }
        public int? FinancialYearIdOld { get; set; }
        public int? FinancialYearIdNew { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ATargets Target { get; set; }
    }
}
