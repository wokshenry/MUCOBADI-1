using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AHhassessmentStatus
    {
        public AHhassessmentStatus()
        {
            Avat = new HashSet<Avat>();
            Hvat = new HashSet<Hvat>();
        }

        public int AssessmentStatusId { get; set; }
        public string AssessmentStatusDescription { get; set; }

        public virtual ICollection<Avat> Avat { get; set; }
        public virtual ICollection<Hvat> Hvat { get; set; }
    }
}
