using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AEidCascade
    {
        public AEidCascade()
        {
            HivTbTrackingFormExposedInfants = new HashSet<HivTbTrackingFormExposedInfants>();
        }

        public int EidCascadeId { get; set; }
        public string EidCascadeDesc { get; set; }

        public virtual ICollection<HivTbTrackingFormExposedInfants> HivTbTrackingFormExposedInfants { get; set; }
    }
}
