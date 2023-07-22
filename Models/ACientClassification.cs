using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ACientClassification
    {
        public ACientClassification()
        {
            HivTbTrackingForm = new HashSet<HivTbTrackingForm>();
        }

        public int CientClassificationId { get; set; }
        public string CientClassificationDesc { get; set; }

        public virtual ICollection<HivTbTrackingForm> HivTbTrackingForm { get; set; }
    }
}
