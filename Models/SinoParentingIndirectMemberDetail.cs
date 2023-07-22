using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SinoParentingIndirectMemberDetail
    {
        public int SinoParentingIndirectMemberDetailId { get; set; }
        public int? SinoParentingIndirectMemberId { get; set; }
        public int? ParentingGroupSessionId { get; set; }
        public DateTime? SessionDate { get; set; }
        public int? ParentAttended { get; set; }
        public int? TeenAttended { get; set; }

        public virtual AYesNo ParentAttendedNavigation { get; set; }
        public virtual AParentingGroupSession ParentingGroupSession { get; set; }
        public virtual SinoParentingIndirectMemberAttendence SinoParentingIndirectMember { get; set; }
        public virtual AYesNo TeenAttendedNavigation { get; set; }
    }
}
