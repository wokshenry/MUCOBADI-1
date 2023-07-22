using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AHheducationLevel
    {
        public AHheducationLevel()
        {
            Hvat = new HashSet<Hvat>();
        }

        public int HheducationLevelId { get; set; }
        public string HheducationLevelDescription { get; set; }

        public virtual ICollection<Hvat> Hvat { get; set; }
    }
}
