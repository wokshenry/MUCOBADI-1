using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AAdministrationPhase
    {
        public AAdministrationPhase()
        {
            Avat = new HashSet<Avat>();
        }

        public int AdministrationPhaseId { get; set; }
        public string AdministrationPhaseDescription { get; set; }

        public virtual ICollection<Avat> Avat { get; set; }
    }
}
