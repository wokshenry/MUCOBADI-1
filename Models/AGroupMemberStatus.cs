using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AGroupMemberStatus
    {
        public AGroupMemberStatus()
        {
            VslaTrackingToolDirectMember = new HashSet<VslaTrackingToolDirectMember>();
            VslaTrackingToolInDirectMember = new HashSet<VslaTrackingToolInDirectMember>();
        }

        public int MemberStausId { get; set; }
        public string MemberStatusDesc { get; set; }

        public virtual ICollection<VslaTrackingToolDirectMember> VslaTrackingToolDirectMember { get; set; }
        public virtual ICollection<VslaTrackingToolInDirectMember> VslaTrackingToolInDirectMember { get; set; }
    }
}
