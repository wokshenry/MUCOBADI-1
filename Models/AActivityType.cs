using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AActivityType
    {
        public AActivityType()
        {
            CommunityTbSensitization = new HashSet<CommunityTbSensitization>();
        }

        public int ActivityTypeId { get; set; }
        public string ActivityTypeDesc { get; set; }

        public virtual ICollection<CommunityTbSensitization> CommunityTbSensitization { get; set; }
    }
}
