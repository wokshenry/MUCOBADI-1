using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewGroups
    {
        public int? GroupId { get; set; }
        public string GroupName { get; set; }
        public string GroupCode { get; set; }
        public int? GroupTypeId { get; set; }
        public string GroupTypeDesc { get; set; }
    }
}
