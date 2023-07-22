using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AIndicators
    {
        public AIndicators()
        {
            ProjectIndicatorTargetsHeader = new HashSet<ProjectIndicatorTargetsHeader>();
            StakeHolderDataCapture = new HashSet<StakeHolderDataCapture>();
        }

        public int IndicatorId { get; set; }
        public string IndicatorCode { get; set; }
        public string ServiceProviderId { get; set; }
        public string IndicatorDescription { get; set; }
        public string Numerator { get; set; }
        public string Denominator { get; set; }
        public int? ResultId { get; set; }
        public int? SubResultId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }

        public virtual ICollection<ProjectIndicatorTargetsHeader> ProjectIndicatorTargetsHeader { get; set; }
        public virtual ICollection<StakeHolderDataCapture> StakeHolderDataCapture { get; set; }
    }
}
