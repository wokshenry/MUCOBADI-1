using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class VslaGroupCommittee
    {
        public int VslagroupCommitteeId { get; set; }
        public int? GroupCompositionCode { get; set; }
        public string MemberName { get; set; }
        public string GenderId { get; set; }
        public int? Age { get; set; }
        public int? GroupPositionId { get; set; }
        public string PhoneNumber { get; set; }

        public virtual AGender Gender { get; set; }
        public virtual VslaGroupComposition GroupCompositionCodeNavigation { get; set; }
        public virtual AGroupPosition GroupPosition { get; set; }
    }
}
