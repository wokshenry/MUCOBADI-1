using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class HivTbRisKassessmentToolHeader
    {
        public HivTbRisKassessmentToolHeader()
        {
            HivTbRisKassessmentTool = new HashSet<HivTbRisKassessmentTool>();
        }

        public int TbriskAssessmentHeaderId { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public int? HouseHoldId { get; set; }

        public virtual ADistrict District { get; set; }
        public virtual BeneficiaryIdentificationRegister HouseHold { get; set; }
        public virtual ASubcounty Subcounty { get; set; }
        public virtual ICollection<HivTbRisKassessmentTool> HivTbRisKassessmentTool { get; set; }
    }
}
