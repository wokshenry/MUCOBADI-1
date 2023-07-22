using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ADrugDispensingModality
    {
        public ADrugDispensingModality()
        {
            HivTbTrackingForm = new HashSet<HivTbTrackingForm>();
        }

        public int DrugDispensingModalityId { get; set; }
        public string DrugDispensingModalityDesc { get; set; }

        public virtual ICollection<HivTbTrackingForm> HivTbTrackingForm { get; set; }
    }
}
