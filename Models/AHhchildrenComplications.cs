using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AHhchildrenComplications
    {
        public AHhchildrenComplications()
        {
            Hvat = new HashSet<Hvat>();
        }

        public int ComplicationsId { get; set; }
        public string ComplicationsDescription { get; set; }
        public double? ComplicationsScores { get; set; }

        public virtual ICollection<Hvat> Hvat { get; set; }
    }
}
