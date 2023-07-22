using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AHhknownHivstatus
    {
        public AHhknownHivstatus()
        {
            Hvat = new HashSet<Hvat>();
        }

        public int KnownHivstatusId { get; set; }
        public string KnownHivstatusDescription { get; set; }
        public double? KnownHivstatusScores { get; set; }

        public virtual ICollection<Hvat> Hvat { get; set; }
    }
}
