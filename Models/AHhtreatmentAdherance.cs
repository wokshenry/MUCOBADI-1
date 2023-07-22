using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AHhtreatmentAdherance
    {
        public AHhtreatmentAdherance()
        {
            Hvat = new HashSet<Hvat>();
        }

        public int TreatmentAdheranceId { get; set; }
        public string TreatmentAdheranceDescription { get; set; }
        public double? TreatmentAdheranceScore { get; set; }

        public virtual ICollection<Hvat> Hvat { get; set; }
    }
}
