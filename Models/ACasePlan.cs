using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ACasePlan
    {
        public ACasePlan()
        {
            CaseCareDetail = new HashSet<CaseCareDetail>();
        }

        public int CasePlanId { get; set; }
        public string CasePlanDesc { get; set; }

        public virtual ICollection<CaseCareDetail> CaseCareDetail { get; set; }
    }
}
