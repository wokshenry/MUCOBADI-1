using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ARequestedTestType
    {
        public ARequestedTestType()
        {
            CommunityTbSensitization = new HashSet<CommunityTbSensitization>();
        }

        public int RequestedTestTypeId { get; set; }
        public string RequestedTestTypeDesc { get; set; }

        public virtual ICollection<CommunityTbSensitization> CommunityTbSensitization { get; set; }
    }
}
