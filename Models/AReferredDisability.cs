using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AReferredDisability
    {
        public AReferredDisability()
        {
            Hvat = new HashSet<Hvat>();
        }

        public int ReferredDisabilityId { get; set; }
        public string ReferredDisabilityDescription { get; set; }
        public double? ReferredDisabilityScore { get; set; }

        public virtual ICollection<Hvat> Hvat { get; set; }
    }
}
