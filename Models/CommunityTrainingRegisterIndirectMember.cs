using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class CommunityTrainingRegisterIndirectMember
    {
        public int CommunityTrainingRegisterIndirectMemberId { get; set; }
        public int? CommunityTrainingRegisterId { get; set; }
        public int? VslaGroupIndirectMemberId { get; set; }
        public int? SessionId { get; set; }
        public DateTime? SessionDate { get; set; }
        public int? SessionDay { get; set; }

        public virtual CommunityTrainingRegister CommunityTrainingRegister { get; set; }
        public virtual ATrainingSession Session { get; set; }
        public virtual VslaGroupIndirectMember VslaGroupIndirectMember { get; set; }
    }
}
