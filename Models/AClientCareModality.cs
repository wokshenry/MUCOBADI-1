using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AClientCareModality
    {
        public AClientCareModality()
        {
            HivTbTrackingForm = new HashSet<HivTbTrackingForm>();
        }

        public int ClientCareModalityId { get; set; }
        public string ClientCareModalityDesc { get; set; }

        public virtual ICollection<HivTbTrackingForm> HivTbTrackingForm { get; set; }
    }
}
