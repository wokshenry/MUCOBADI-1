using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AAdolescentEnrolledAttendingSchool
    {
        public AAdolescentEnrolledAttendingSchool()
        {
            Avat = new HashSet<Avat>();
        }

        public int EnrolledId { get; set; }
        public string EnrolledDesc { get; set; }
        public double? EnrolledScore { get; set; }

        public virtual ICollection<Avat> Avat { get; set; }
    }
}
