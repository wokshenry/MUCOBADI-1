using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class APersonContacted
    {
        public APersonContacted()
        {
            HivTbTrackingForm = new HashSet<HivTbTrackingForm>();
        }

        public int PersonContactedId { get; set; }
        public string PersonContactedDesc { get; set; }

        public virtual ICollection<HivTbTrackingForm> HivTbTrackingForm { get; set; }
    }
}
