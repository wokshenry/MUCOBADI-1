using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ATuberclosisTreatment
    {
        public ATuberclosisTreatment()
        {
            Hvat = new HashSet<Hvat>();
        }

        public int TreatmentId { get; set; }
        public string TreatmentDescription { get; set; }
        public double? TreatmentScore { get; set; }

        public virtual ICollection<Hvat> Hvat { get; set; }
    }
}
