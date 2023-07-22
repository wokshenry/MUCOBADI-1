using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AEducationLevel
    {
        public AEducationLevel()
        {
            HouseHoldMembers = new HashSet<HouseHoldMembers>();
        }

        public int EducationLevelId { get; set; }
        public string EducationLevelDescription { get; set; }

        public virtual ICollection<HouseHoldMembers> HouseHoldMembers { get; set; }
    }
}
