using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ATbScreeningVenue
    {
        public ATbScreeningVenue()
        {
            CommunityTbSensitization = new HashSet<CommunityTbSensitization>();
        }

        public int TbScreeningVenueId { get; set; }
        public string TbScreeningVenueDesc { get; set; }

        public virtual ICollection<CommunityTbSensitization> CommunityTbSensitization { get; set; }
    }
}
