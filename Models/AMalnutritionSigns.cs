using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AMalnutritionSigns
    {
        public AMalnutritionSigns()
        {
            Hvat = new HashSet<Hvat>();
        }

        public int MalnutritionSignId { get; set; }
        public string MalnutritionSignDescription { get; set; }

        public virtual ICollection<Hvat> Hvat { get; set; }
    }
}
