using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class APosition
    {
        public APosition()
        {
            AContacts = new HashSet<AContacts>();
        }

        public int PositionId { get; set; }
        public string PositionDesc { get; set; }

        public virtual ICollection<AContacts> AContacts { get; set; }
    }
}
