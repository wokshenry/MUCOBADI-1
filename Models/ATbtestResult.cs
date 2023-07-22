using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ATbtestResult
    {
        public ATbtestResult()
        {
            HivTbTrackingForm = new HashSet<HivTbTrackingForm>();
        }

        public int TbtestResultId { get; set; }
        public string TbtestResultDesc { get; set; }

        public virtual ICollection<HivTbTrackingForm> HivTbTrackingForm { get; set; }
    }
}
