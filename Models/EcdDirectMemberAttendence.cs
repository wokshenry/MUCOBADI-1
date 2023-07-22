using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class EcdDirectMemberAttendence
    {
        public EcdDirectMemberAttendence()
        {
            EcdDirectMemberDetail = new HashSet<EcdDirectMemberDetail>();
        }

        public int SinoParentingDirectMemberId { get; set; }
        public int? SinoParentingId { get; set; }
        public int? CareTakerHouseholdMemberId { get; set; }
        public int? VslaGroupDirectMemberId { get; set; }
        public int? RelationshipId { get; set; }

        public virtual HouseHoldMembers CareTakerHouseholdMember { get; set; }
        public virtual ARelationship Relationship { get; set; }
        public virtual EcdAttendenceRegister SinoParenting { get; set; }
        public virtual VslaGroupDirectMembers VslaGroupDirectMember { get; set; }
        public virtual ICollection<EcdDirectMemberDetail> EcdDirectMemberDetail { get; set; }
    }
}
