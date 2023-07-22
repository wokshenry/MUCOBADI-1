using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class OvcSchoolAttendencyDetails
    {
        public int SchoolAttendencyDetailsId { get; set; }
        public int? SchoolAttendencyHeaderId { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public int? ClassatEnrolmentId { get; set; }
        public string SchoolName { get; set; }
        public int? CurrentClassId { get; set; }
        public string CandidentClassCompletedId { get; set; }
        public int? AttendencyId { get; set; }

        public virtual AAttendency Attendency { get; set; }
        public virtual ACurrentClass ClassatEnrolment { get; set; }
        public virtual ACurrentClass CurrentClass { get; set; }
        public virtual HouseHoldMembers HouseHoldMember { get; set; }
        public virtual OvcSchoolAttendencyHeader SchoolAttendencyHeader { get; set; }
    }
}
