using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AAttendency
    {
        public AAttendency()
        {
            OvcSchoolAttendencyDetails = new HashSet<OvcSchoolAttendencyDetails>();
        }

        public int AttendencyId { get; set; }
        public string AttendencyDesc { get; set; }

        public virtual ICollection<OvcSchoolAttendencyDetails> OvcSchoolAttendencyDetails { get; set; }
    }
}
