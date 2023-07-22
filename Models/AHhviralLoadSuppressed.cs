using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AHhviralLoadSuppressed
    {
        public AHhviralLoadSuppressed()
        {
            Hvat = new HashSet<Hvat>();
        }

        public int HhviralLoadSuppresedId { get; set; }
        public string HhviralLoadSuppresedDescription { get; set; }
        public double? HhviralLoadSuppresedScores { get; set; }

        public virtual ICollection<Hvat> Hvat { get; set; }
    }
}
