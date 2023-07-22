using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ARelationship
    {
        public ARelationship()
        {
            EcdDirectMemberAttendence = new HashSet<EcdDirectMemberAttendence>();
            EcdIndirectMemberAttendence = new HashSet<EcdIndirectMemberAttendence>();
            ReferralForm = new HashSet<ReferralForm>();
            SinoParentingDirectMemberAttendence = new HashSet<SinoParentingDirectMemberAttendence>();
            SinoParentingIndirectMemberAttendence = new HashSet<SinoParentingIndirectMemberAttendence>();
        }

        public int RelationshipId { get; set; }
        public string RelationshipName { get; set; }

        public virtual ICollection<EcdDirectMemberAttendence> EcdDirectMemberAttendence { get; set; }
        public virtual ICollection<EcdIndirectMemberAttendence> EcdIndirectMemberAttendence { get; set; }
        public virtual ICollection<ReferralForm> ReferralForm { get; set; }
        public virtual ICollection<SinoParentingDirectMemberAttendence> SinoParentingDirectMemberAttendence { get; set; }
        public virtual ICollection<SinoParentingIndirectMemberAttendence> SinoParentingIndirectMemberAttendence { get; set; }
    }
}
