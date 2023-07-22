using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ACareGiver
    {
        public ACareGiver()
        {
            HouseHoldMembers = new HashSet<HouseHoldMembers>();
        }

        public int CareGiverId { get; set; }
        public string CareGiverDesc { get; set; }

        public virtual ICollection<HouseHoldMembers> HouseHoldMembers { get; set; }
    }
}
