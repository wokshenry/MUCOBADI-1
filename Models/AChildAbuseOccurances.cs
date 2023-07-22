using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AChildAbuseOccurances
    {
        public AChildAbuseOccurances()
        {
            Hvat = new HashSet<Hvat>();
        }

        public int OccuranceId { get; set; }
        public string OccuranceDescription { get; set; }

        public virtual ICollection<Hvat> Hvat { get; set; }
    }
}
