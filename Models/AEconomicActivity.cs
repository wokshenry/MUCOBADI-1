using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AEconomicActivity
    {
        public AEconomicActivity()
        {
            Avat = new HashSet<Avat>();
        }

        public int EconomicActivityId { get; set; }
        public string EconomicActivityDescription { get; set; }
        public double? EconomicActivityScore { get; set; }

        public virtual ICollection<Avat> Avat { get; set; }
    }
}
