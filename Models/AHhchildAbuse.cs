using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AHhchildAbuse
    {
        public AHhchildAbuse()
        {
            Avat = new HashSet<Avat>();
            Hvat = new HashSet<Hvat>();
        }

        public int ChildAbuseId { get; set; }
        public string ChildAbuseDescription { get; set; }
        public double? ChildAbuseScores { get; set; }

        public virtual ICollection<Avat> Avat { get; set; }
        public virtual ICollection<Hvat> Hvat { get; set; }
    }
}
