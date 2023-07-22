using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AViralLoadLevel
    {
        public AViralLoadLevel()
        {
            HivTbRisKassessmentTool = new HashSet<HivTbRisKassessmentTool>();
        }

        public int ViralLoadLevelId { get; set; }
        public string ViralLoadLevelDesc { get; set; }

        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentTool { get; set; }
    }
}
