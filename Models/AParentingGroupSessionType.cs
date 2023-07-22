using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AParentingGroupSessionType
    {
        public AParentingGroupSessionType()
        {
            AParentingGroupSession = new HashSet<AParentingGroupSession>();
        }

        public int ParentingGroupSessionTypeId { get; set; }
        public string ParentingGroupSessionTypedesc { get; set; }

        public virtual ICollection<AParentingGroupSession> AParentingGroupSession { get; set; }
    }
}
