using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ACasePlanStaus
    {
        public ACasePlanStaus()
        {
            CaseCareDetailPlan = new HashSet<CaseCareDetailPlan>();
        }

        public int CasePlanStausId { get; set; }
        public string CasePlanStausDesc { get; set; }

        public virtual ICollection<CaseCareDetailPlan> CaseCareDetailPlan { get; set; }
    }
}
