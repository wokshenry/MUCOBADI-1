using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class APriorityAreaCodes
    {
        public int PriorityAreaCodeId { get; set; }
        public int PriorityAreaId { get; set; }
        public string PriorityAreaCodeDesc { get; set; }

        public virtual APriorityArea PriorityArea { get; set; }
    }
}
