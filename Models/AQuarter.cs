using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AQuarter
    {
        public AQuarter()
        {
            StakeHolderDataCapture = new HashSet<StakeHolderDataCapture>();
        }

        public int QuarterId { get; set; }
        public string QuarterName { get; set; }
        public int? StartMonthId { get; set; }
        public int? EndMonthId { get; set; }

        public virtual AMonth EndMonth { get; set; }
        public virtual AMonth StartMonth { get; set; }
        public virtual ICollection<StakeHolderDataCapture> StakeHolderDataCapture { get; set; }
    }
}
