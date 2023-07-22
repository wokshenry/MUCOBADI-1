using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AHhincome
    {
        public AHhincome()
        {
            Hvat = new HashSet<Hvat>();
        }

        public int HouseHoldIncomeId { get; set; }
        public string HouseHoldIncomeDescription { get; set; }
        public double? HouseHoldIncomeScore { get; set; }

        public virtual ICollection<Hvat> Hvat { get; set; }
    }
}
