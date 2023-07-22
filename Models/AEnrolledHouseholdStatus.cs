using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AEnrolledHouseholdStatus
    {
        public AEnrolledHouseholdStatus()
        {
            GraduationBenchMark = new HashSet<GraduationBenchMark>();
        }

        public int HouseholdStatusId { get; set; }
        public string HouseholdStatusDescription { get; set; }

        public virtual ICollection<GraduationBenchMark> GraduationBenchMark { get; set; }
    }
}
