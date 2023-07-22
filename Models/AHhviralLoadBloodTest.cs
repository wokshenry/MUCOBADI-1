using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AHhviralLoadBloodTest
    {
        public AHhviralLoadBloodTest()
        {
            Hvat = new HashSet<Hvat>();
        }

        public int BloodTestId { get; set; }
        public string BloodTestDescription { get; set; }
        public double? BloodTestScore { get; set; }

        public virtual ICollection<Hvat> Hvat { get; set; }
    }
}
