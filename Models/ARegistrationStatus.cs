using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ARegistrationStatus
    {
        public ARegistrationStatus()
        {
            HivTbTrackingFormExposedInfants = new HashSet<HivTbTrackingFormExposedInfants>();
        }

        public int RegistrationStatusId { get; set; }
        public string RegistrationStatusDesc { get; set; }

        public virtual ICollection<HivTbTrackingFormExposedInfants> HivTbTrackingFormExposedInfants { get; set; }
    }
}
