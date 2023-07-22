using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AGraduationCriteria
    {
        public AGraduationCriteria()
        {
            GraduationChecklistDetail = new HashSet<GraduationChecklistDetail>();
        }

        public int GraduationCriteriaId { get; set; }
        public string GraduationCriteriaCategory { get; set; }
        public string GraduationCriteriaDesc { get; set; }
        public string GraduationCriteriaGuidline { get; set; }

        public virtual ICollection<GraduationChecklistDetail> GraduationChecklistDetail { get; set; }
    }
}
