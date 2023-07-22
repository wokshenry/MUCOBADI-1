using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AAdolescentHealthServiceReferred
    {
        public AAdolescentHealthServiceReferred()
        {
            Avat = new HashSet<Avat>();
        }

        public int ReferredId { get; set; }
        public string ReferredDescription { get; set; }
        public double? ReferredScore { get; set; }

        public virtual ICollection<Avat> Avat { get; set; }
    }
}
