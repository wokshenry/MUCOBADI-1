using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ATargets
    {
        public ATargets()
        {
            ATargetsLog = new HashSet<ATargetsLog>();
        }

        public int TargetId { get; set; }
        public double? TargetValue { get; set; }
        public int? DistrictId { get; set; }
        public int? FinancialYearId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }

        public virtual ADistrict District { get; set; }
        public virtual AFinancialYear FinancialYear { get; set; }
        public virtual ICollection<ATargetsLog> ATargetsLog { get; set; }
    }
}
