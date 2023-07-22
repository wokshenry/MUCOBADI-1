using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AGroupPosition
    {
        public AGroupPosition()
        {
            VslaGroupCommittee = new HashSet<VslaGroupCommittee>();
        }

        public int GroupPositionId { get; set; }
        public string GroupPositionDesc { get; set; }

        public virtual ICollection<VslaGroupCommittee> VslaGroupCommittee { get; set; }
    }
}
