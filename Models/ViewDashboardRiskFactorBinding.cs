using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewDashboardRiskFactorBinding
    {
        public int RiskFactorBindingId { get; set; }
        public string RiskFactorsDescription { get; set; }
        public int? KnownRiskFactorId { get; set; }
        public string KnownRiskFactorDescription { get; set; }
    }
}
