using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class VslaGroupShareOutIndirectMember
    {
        public int VslashareOutInDirectMemberId { get; set; }
        public int? VslashareOutHeaderId { get; set; }
        public int? VslaGroupIndirectMemberId { get; set; }
        public double? TotalNumberOfSharesBought { get; set; }
        public double? TotalSaving { get; set; }
        public double? NewShareValue { get; set; }
        public double? CalculatedAmountToBeSharedOut { get; set; }
        public double? ActualAmountShared { get; set; }

        public virtual VslaGroupIndirectMember VslaGroupIndirectMember { get; set; }
        public virtual VslaGroupShareOutHeader VslashareOutHeader { get; set; }
    }
}
