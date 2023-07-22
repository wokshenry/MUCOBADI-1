using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class Avat
    {
        public int AvatId { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public int? HouseHoldId { get; set; }
        public DateTime? InterviewDate { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public string Cdoname { get; set; }
        public string Cdocontact { get; set; }
        public int? AdministrationPhaseId { get; set; }
        public int? MaritalStatusId { get; set; }
        public int? EconomicActivityId { get; set; }
        public double? EconomicActivityScore { get; set; }
        public string HarmfulId { get; set; }
        public double? HarmfulScore { get; set; }
        public int? IsSavingsGroupMember { get; set; }
        public double? IsSavingsGroupMemberScore { get; set; }
        public string MemberBenefitsId { get; set; }
        public double? MemberBenefitsScore { get; set; }
        public double? EconomicStabilityTotal { get; set; }
        public int? MealId { get; set; }
        public double? MealScore { get; set; }
        public int? LackofFood { get; set; }
        public double? LackofFoodScore { get; set; }
        public int? ReferredId { get; set; }
        public double? ReferredScore { get; set; }
        public int? AdolescentWithKnownHivstatus { get; set; }
        public double? AdolescentWithKnownHivstatusScore { get; set; }
        public int? AntiretroviralTherapy { get; set; }
        public double? AntiretroviralTherapyScore { get; set; }
        public int? HadViralLoadBloodTest { get; set; }
        public double? HadViralLoadBloodTestScore { get; set; }
        public int? IsViralloadSuppressed { get; set; }
        public double? IsViralloadSuppressedScore { get; set; }
        public string InfectionWayId { get; set; }
        public double? InfectionWayScore { get; set; }
        public string SelfProtectionId { get; set; }
        public double? SelfProtectionScore { get; set; }
        public double? SurvivalandHealthTotal { get; set; }
        public int? EnrolledId { get; set; }
        public double? EnrolledScore { get; set; }
        public int? HasAttendedSchool { get; set; }
        public double? HasAttendedSchoolScore { get; set; }
        public int? AdolescentProgressing { get; set; }
        public string ProgressingReasonId { get; set; }
        public double? ProgressingReasonScore { get; set; }
        public double? EducationandDevelopmentTotal { get; set; }
        public int? SameAdultPrimaryCareGiver { get; set; }
        public double? SameAdultPrimaryCareGiverScore { get; set; }
        public int? FeelingWithdrawn { get; set; }
        public double? FeelingWithdrawnScore { get; set; }
        public int? ChildAbuseId { get; set; }
        public double? ChildAbuseScore { get; set; }
        public string IssueOfAbuseId { get; set; }
        public double? IssueOfAbuseScore { get; set; }
        public string ViolenceId { get; set; }
        public double? ViolenceScore { get; set; }
        public double? CareandProtectionTotal { get; set; }
        public double? HhtotalScore { get; set; }
        public double? AveragePercentage { get; set; }
        public int? AssessmentStatusId { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public string AssessorObservation { get; set; }
        public string AssessorName { get; set; }
        public string AssessorTitle { get; set; }
        public string AssessorContact { get; set; }

        public virtual AAdministrationPhase AdministrationPhase { get; set; }
        public virtual AYesNo AdolescentProgressingNavigation { get; set; }
        public virtual AYesNo AdolescentWithKnownHivstatusNavigation { get; set; }
        public virtual AYesNo AntiretroviralTherapyNavigation { get; set; }
        public virtual AHhassessmentStatus AssessmentStatus { get; set; }
        public virtual AHhchildAbuse ChildAbuse { get; set; }
        public virtual ADistrict District { get; set; }
        public virtual AEconomicActivity EconomicActivity { get; set; }
        public virtual AAdolescentEnrolledAttendingSchool Enrolled { get; set; }
        public virtual AYesNo FeelingWithdrawnNavigation { get; set; }
        public virtual AYesNo HadViralLoadBloodTestNavigation { get; set; }
        public virtual AYesNo HasAttendedSchoolNavigation { get; set; }
        public virtual BeneficiaryIdentificationRegister HouseHold { get; set; }
        public virtual HouseHoldMembers HouseHoldMember { get; set; }
        public virtual AYesNo IsSavingsGroupMemberNavigation { get; set; }
        public virtual AYesNo IsViralloadSuppressedNavigation { get; set; }
        public virtual AYesNo LackofFoodNavigation { get; set; }
        public virtual AMaritalStatus MaritalStatus { get; set; }
        public virtual ADailyMeals Meal { get; set; }
        public virtual AAdolescentHealthServiceReferred Referred { get; set; }
        public virtual AYesNo SameAdultPrimaryCareGiverNavigation { get; set; }
        public virtual ASubcounty Subcounty { get; set; }
    }
}
