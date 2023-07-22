using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class CommunityTrainingRegisterDirectMember
    {
        public int CommunityTrainingRegisterDirectMemberId { get; set; }
        public int? CommunityTrainingRegisterId { get; set; }
        public int? VslaGroupDirectMemberId { get; set; }
        public int? SessionId { get; set; }
        public DateTime? SessionDate { get; set; }
        public int? SessionDay { get; set; }

        public virtual CommunityTrainingRegister CommunityTrainingRegister { get; set; }
        public virtual ATrainingSession Session { get; set; }
        public virtual VslaGroupDirectMembers VslaGroupDirectMember { get; set; }
    }
}
