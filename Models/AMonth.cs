using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AMonth
    {
        public AMonth()
        {
            AQuarterEndMonth = new HashSet<AQuarter>();
            AQuarterStartMonth = new HashSet<AQuarter>();
            VslaTrackingToolDirectMember = new HashSet<VslaTrackingToolDirectMember>();
            VslaTrackingToolInDirectMember = new HashSet<VslaTrackingToolInDirectMember>();
        }

        public int MonthId { get; set; }
        public string MonthDesc { get; set; }

        public virtual ICollection<AQuarter> AQuarterEndMonth { get; set; }
        public virtual ICollection<AQuarter> AQuarterStartMonth { get; set; }
        public virtual ICollection<VslaTrackingToolDirectMember> VslaTrackingToolDirectMember { get; set; }
        public virtual ICollection<VslaTrackingToolInDirectMember> VslaTrackingToolInDirectMember { get; set; }
    }
}
