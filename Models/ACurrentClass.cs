using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ACurrentClass
    {
        public ACurrentClass()
        {
            OvcSchoolAttendencyDetailsClassatEnrolment = new HashSet<OvcSchoolAttendencyDetails>();
            OvcSchoolAttendencyDetailsCurrentClass = new HashSet<OvcSchoolAttendencyDetails>();
        }

        public int CurrentClassId { get; set; }
        public string CurrentClassDesc { get; set; }

        public virtual ICollection<OvcSchoolAttendencyDetails> OvcSchoolAttendencyDetailsClassatEnrolment { get; set; }
        public virtual ICollection<OvcSchoolAttendencyDetails> OvcSchoolAttendencyDetailsCurrentClass { get; set; }
    }
}
