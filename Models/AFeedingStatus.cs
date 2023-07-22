using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AFeedingStatus
    {
        public AFeedingStatus()
        {
            HivTbTrackingFormExposedInfants = new HashSet<HivTbTrackingFormExposedInfants>();
        }

        public int FeedingStatusId { get; set; }
        public string FeedingStatusDesc { get; set; }

        public virtual ICollection<HivTbTrackingFormExposedInfants> HivTbTrackingFormExposedInfants { get; set; }
    }
}
