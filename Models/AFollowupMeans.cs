using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AFollowupMeans
    {
        public AFollowupMeans()
        {
            HivTbTrackingForm = new HashSet<HivTbTrackingForm>();
        }

        public int FollowupMeansId { get; set; }
        public string FollowupMeansDescription { get; set; }

        public virtual ICollection<HivTbTrackingForm> HivTbTrackingForm { get; set; }
    }
}
