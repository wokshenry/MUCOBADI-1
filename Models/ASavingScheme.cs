using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ASavingScheme
    {
        public ASavingScheme()
        {
            Hvat = new HashSet<Hvat>();
        }

        public int SavingSchemeId { get; set; }
        public string SavingSchemeDescription { get; set; }
        public double? SavingSchemeScore { get; set; }

        public virtual ICollection<Hvat> Hvat { get; set; }
    }
}
