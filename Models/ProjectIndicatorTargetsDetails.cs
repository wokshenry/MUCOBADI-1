using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ProjectIndicatorTargetsDetails
    {
        public int IndicatorTargetValueId { get; set; }
        public int? ProjectTargetValueHeaderId { get; set; }
        public int? DistrictId { get; set; }
        public double? TargetValue { get; set; }
        public DateTime? DateCaptured { get; set; }
        public string CapturedBy { get; set; }

        public virtual ADistrict District { get; set; }
        public virtual ProjectIndicatorTargetsHeader ProjectTargetValueHeader { get; set; }
    }
}
