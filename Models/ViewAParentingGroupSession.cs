using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewAParentingGroupSession
    {
        public int ParentingGroupSessionId { get; set; }
        public string ParentingGroupSessionDesc { get; set; }
        public int? ParentingGroupSessionTypeId { get; set; }
        public string ParentingGroupSessionTypedesc { get; set; }
    }
}
