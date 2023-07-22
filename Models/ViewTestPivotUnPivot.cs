using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewTestPivotUnPivot
    {
        public string EconomicStabilityServiceReceived { get; set; }
        public string EducationReceived { get; set; }
        public string Pssreceived { get; set; }
        public string ChildProtectionServiceReceived { get; set; }
        public string FoodSecurityNutritionReceived { get; set; }
        public string HealthServiceReceived { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictDescription { get; set; }
        public int? SubcountyId { get; set; }
        public string SubcountyDescription { get; set; }
        public int? ActualAge { get; set; }
        public string AgeBands { get; set; }
        public string AgeCategory { get; set; }
        public string GenderDescription { get; set; }
        public DateTime? VisitationDate { get; set; }
        public int? VisitationYear { get; set; }
        public int? VisitationMonth { get; set; }
        public string GenderId { get; set; }
        public string HivstatusDescription { get; set; }
        public int? HivstatusId { get; set; }
    }
}
