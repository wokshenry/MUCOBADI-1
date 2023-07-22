using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ATerm
    {
        public ATerm()
        {
            MonthlyCaseTrackingRegister = new HashSet<MonthlyCaseTrackingRegister>();
            OvcSchoolAttendencyHeader = new HashSet<OvcSchoolAttendencyHeader>();
        }

        public int TermId { get; set; }
        public string TermDesc { get; set; }

        public virtual ICollection<MonthlyCaseTrackingRegister> MonthlyCaseTrackingRegister { get; set; }
        public virtual ICollection<OvcSchoolAttendencyHeader> OvcSchoolAttendencyHeader { get; set; }
    }
}
