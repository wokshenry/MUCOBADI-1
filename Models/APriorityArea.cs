using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class APriorityArea
    {
        public APriorityArea()
        {
            APriorityAreaCodes = new HashSet<APriorityAreaCodes>();
            CaseCareDetailPlan = new HashSet<CaseCareDetailPlan>();
        }

        public int PriorityAreaId { get; set; }
        public string PriorityAreaDesc { get; set; }

        public virtual ICollection<APriorityAreaCodes> APriorityAreaCodes { get; set; }
        public virtual ICollection<CaseCareDetailPlan> CaseCareDetailPlan { get; set; }
    }
}
