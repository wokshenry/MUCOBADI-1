using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AHhpreSchoolNotEnrolled
    {
        public AHhpreSchoolNotEnrolled()
        {
            Hvat = new HashSet<Hvat>();
        }

        public int PreSchoolNotEnrolledId { get; set; }
        public string PreSchoolNotEnrolledDescription { get; set; }
        public double? PreSchoolNotEnrolledScore { get; set; }

        public virtual ICollection<Hvat> Hvat { get; set; }
    }
}
