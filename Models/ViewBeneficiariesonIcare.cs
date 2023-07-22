using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewBeneficiariesonIcare
    {
        public int? TotalNumber { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictDescription { get; set; }
        public int? KnownRiskFactorId { get; set; }
        public string KnownRiskFactorDescription { get; set; }
        public int? Qtr { get; set; }
        public int? VisitationYear { get; set; }
    }
}
