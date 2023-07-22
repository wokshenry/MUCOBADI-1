using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ATbclientRefered
    {
        public ATbclientRefered()
        {
            HivTbTrackingForm = new HashSet<HivTbTrackingForm>();
        }

        public int TbreferedId { get; set; }
        public string TbreferedDesc { get; set; }

        public virtual ICollection<HivTbTrackingForm> HivTbTrackingForm { get; set; }
    }
}
