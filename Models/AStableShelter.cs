using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AStableShelter
    {
        public AStableShelter()
        {
            Hvat = new HashSet<Hvat>();
        }

        public int ShelterId { get; set; }
        public string ShelterDescription { get; set; }
        public double? ShelterScores { get; set; }

        public virtual ICollection<Hvat> Hvat { get; set; }
    }
}
