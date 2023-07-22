using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class CommunityTbSensitization
    {
        public int SensitizationId { get; set; }
        public int? DistrictId { get; set; }
        public int? SubCountyId { get; set; }
        public int? ParishId { get; set; }
        public int? VillageId { get; set; }
        public string ClientName { get; set; }
        public DateTime? Dob { get; set; }
        public int? Age { get; set; }
        public string GenderId { get; set; }
        public string PhoneNumber { get; set; }
        public int? ActivityTypeId { get; set; }
        public int? TbScreeningVenueId { get; set; }
        public DateTime? ActivityDate { get; set; }
        public int? IsSensitisedOnTb { get; set; }
        public int? IsCoughing { get; set; }
        public int? DaysCoughing { get; set; }
        public int? IsCoughingUpBlood { get; set; }
        public int? HasFever { get; set; }
        public int? DaysWithFever { get; set; }
        public int? WeightLoss { get; set; }
        public int? ExcessiveNightSweats { get; set; }
        public int? OtherSymptoms { get; set; }
        public string OtherSymptomDesc { get; set; }
        public int? IsaclientapresumptiveTbcase { get; set; }
        public int? RequestedTestTypeId { get; set; }
        public int? ClientReferedForEvaluation { get; set; }

        public virtual AActivityType ActivityType { get; set; }
        public virtual AYesNo ClientReferedForEvaluationNavigation { get; set; }
        public virtual ADistrict District { get; set; }
        public virtual AYesNo ExcessiveNightSweatsNavigation { get; set; }
        public virtual AGender Gender { get; set; }
        public virtual AYesNo HasFeverNavigation { get; set; }
        public virtual AYesNo IsCoughingNavigation { get; set; }
        public virtual AYesNo IsCoughingUpBloodNavigation { get; set; }
        public virtual AYesNo IsSensitisedOnTbNavigation { get; set; }
        public virtual AYesNo IsaclientapresumptiveTbcaseNavigation { get; set; }
        public virtual AYesNo OtherSymptomsNavigation { get; set; }
        public virtual AParish Parish { get; set; }
        public virtual ARequestedTestType RequestedTestType { get; set; }
        public virtual ASubcounty SubCounty { get; set; }
        public virtual ATbScreeningVenue TbScreeningVenue { get; set; }
        public virtual AVillage Village { get; set; }
        public virtual AYesNo WeightLossNavigation { get; set; }
    }
}
