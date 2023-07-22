using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AFoodConsumedSource
    {
        public AFoodConsumedSource()
        {
            Hvat = new HashSet<Hvat>();
        }

        public int FoodConsumedId { get; set; }
        public string FoodConsumedDescription { get; set; }
        public double? FoodConsumedScore { get; set; }

        public virtual ICollection<Hvat> Hvat { get; set; }
    }
}
