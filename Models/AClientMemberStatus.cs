using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AClientMemberStatus
    {
        public AClientMemberStatus()
        {
            HivTbTrackingForm = new HashSet<HivTbTrackingForm>();
        }

        public int ClientMemberStatusId { get; set; }
        public string ClientMemberStatusDes { get; set; }

        public virtual ICollection<HivTbTrackingForm> HivTbTrackingForm { get; set; }
    }
}
