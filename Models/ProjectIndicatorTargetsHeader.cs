using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ProjectIndicatorTargetsHeader
    {
        public ProjectIndicatorTargetsHeader()
        {
            ProjectIndicatorTargetsDetails = new HashSet<ProjectIndicatorTargetsDetails>();
        }

        public int ProjectTargetValueHeaderId { get; set; }
        public int? ServiceProviderId { get; set; }
        public int? FinancialYearId { get; set; }
        public int? IndicatorId { get; set; }
        public string CapturedBy { get; set; }
        public DateTime? DateCaptured { get; set; }

        public virtual AFinancialYear FinancialYear { get; set; }
        public virtual AIndicators Indicator { get; set; }
        public virtual AServiceProvider ServiceProvider { get; set; }
        public virtual ICollection<ProjectIndicatorTargetsDetails> ProjectIndicatorTargetsDetails { get; set; }
    }
}
