using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ATbtreatment
    {
        public ATbtreatment()
        {
            HivTbTrackingFormIsOnTbpreventiveTreatmentNavigation = new HashSet<HivTbTrackingForm>();
            HivTbTrackingFormIsOnTbtreatmentNavigation = new HashSet<HivTbTrackingForm>();
        }

        public int TbtreatmentId { get; set; }
        public string TbtreatmentDesc { get; set; }

        public virtual ICollection<HivTbTrackingForm> HivTbTrackingFormIsOnTbpreventiveTreatmentNavigation { get; set; }
        public virtual ICollection<HivTbTrackingForm> HivTbTrackingFormIsOnTbtreatmentNavigation { get; set; }
    }
}
