using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewDashboardOvcServiceReportingToolDetail
    {
        public int VisitServiceReportingToolDetailId { get; set; }
        public int? VisitServiceReportingToolHeaderId { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public int? ProgramParticipationId { get; set; }
        public string Stable { get; set; }
        public string EconomicStabilityServiceReceived { get; set; }
        public string StableOther { get; set; }
        public string Schooled { get; set; }
        public string EducationReceived { get; set; }
        public string SchooledOther { get; set; }
        public string Safe { get; set; }
        public string Pssreceived { get; set; }
        public string ChildProtectionServiceReceived { get; set; }
        public string SafeOther { get; set; }
        public string Healthy { get; set; }
        public string FoodSecurityNutritionReceived { get; set; }
        public string HealthServiceReceived { get; set; }
        public string HealthyOther { get; set; }
        public string GapNeededStable { get; set; }
        public string GapNeededSchooled { get; set; }
        public string GapNeededSafe { get; set; }
        public string GapNeededHealthy { get; set; }
        public string EmergingNeedStable { get; set; }
        public string EmergingNeedSchooled { get; set; }
        public string EmergingNeedSafe { get; set; }
        public string EmergingNeedHealthy { get; set; }
        public string UnmetNeedStable { get; set; }
        public string UnmetNeedSchooled { get; set; }
        public string UnmetNeedSafe { get; set; }
        public string UnmetNeedHealthy { get; set; }
        public string IssuesIdentified { get; set; }
        public int? HouseHoldId { get; set; }
        public DateTime? DoB { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictDescription { get; set; }
        public int? SubcountyId { get; set; }
        public string SubcountyDescription { get; set; }
        public int? ActualAge { get; set; }
        public string AgeBands { get; set; }
        public string AgeCategory { get; set; }
        public string GenderDescription { get; set; }
        public DateTime? VisitationDate { get; set; }
        public string Qtr { get; set; }
        public int? VisitationYear { get; set; }
        public int? VisitationMonth { get; set; }
        public string GenderId { get; set; }
        public string HivstatusDescription { get; set; }
        public int? HivstatusId { get; set; }
    }
}
