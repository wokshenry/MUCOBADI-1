using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ATbtreatmentDuration
    {
        public ATbtreatmentDuration()
        {
            HivTbTrackingForm = new HashSet<HivTbTrackingForm>();
        }

        public int TbtreatmentDurationId { get; set; }
        public string TbtreatmentDurationDesc { get; set; }

        public virtual ICollection<HivTbTrackingForm> HivTbTrackingForm { get; set; }
    }
}
