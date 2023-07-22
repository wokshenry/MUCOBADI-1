using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class SinoParentingIndirectMemberAttendence
    {
        public SinoParentingIndirectMemberAttendence()
        {
            SinoParentingIndirectMemberDetail = new HashSet<SinoParentingIndirectMemberDetail>();
        }

        public int SinoParentingIndirectMemberId { get; set; }
        public int? SinoParentingId { get; set; }
        public string CareTakerHouseholdMemberCode { get; set; }
        public string CareTakerName { get; set; }
        public int? CareTakerAge { get; set; }
        public string CareTakerGenderId { get; set; }
        public int? VslaGroupIndirectMemberId { get; set; }
        public int? RelationshipId { get; set; }

        public virtual AGender CareTakerGender { get; set; }
        public virtual ARelationship Relationship { get; set; }
        public virtual SinoParentingAttendenceRegister SinoParenting { get; set; }
        public virtual VslaGroupIndirectMember VslaGroupIndirectMember { get; set; }
        public virtual ICollection<SinoParentingIndirectMemberDetail> SinoParentingIndirectMemberDetail { get; set; }
    }
}
