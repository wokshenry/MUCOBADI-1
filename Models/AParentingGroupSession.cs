using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AParentingGroupSession
    {
        public AParentingGroupSession()
        {
            EcdDirectMemberDetail = new HashSet<EcdDirectMemberDetail>();
            EcdIndirectMemberDetail = new HashSet<EcdIndirectMemberDetail>();
            SinoParentingDirectMemberDetail = new HashSet<SinoParentingDirectMemberDetail>();
            SinoParentingIndirectMemberDetail = new HashSet<SinoParentingIndirectMemberDetail>();
        }

        public int ParentingGroupSessionId { get; set; }
        public string ParentingGroupSessionDesc { get; set; }
        public int? ParentingGroupSessionTypeId { get; set; }

        public virtual AParentingGroupSessionType ParentingGroupSessionType { get; set; }
        public virtual ICollection<EcdDirectMemberDetail> EcdDirectMemberDetail { get; set; }
        public virtual ICollection<EcdIndirectMemberDetail> EcdIndirectMemberDetail { get; set; }
        public virtual ICollection<SinoParentingDirectMemberDetail> SinoParentingDirectMemberDetail { get; set; }
        public virtual ICollection<SinoParentingIndirectMemberDetail> SinoParentingIndirectMemberDetail { get; set; }
    }
}
