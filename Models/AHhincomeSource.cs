using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AHhincomeSource
    {
        public AHhincomeSource()
        {
            Hvat = new HashSet<Hvat>();
        }

        public int IncomeSourceId { get; set; }
        public string IncomeSourceDescription { get; set; }
        public double? IncomeSourceScore { get; set; }

        public virtual ICollection<Hvat> Hvat { get; set; }
    }
}
