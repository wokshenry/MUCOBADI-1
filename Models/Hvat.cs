using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class Hvat
    {
        public int Hvatid { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public int? HouseHoldId { get; set; }
        public string ServiceProviderName { get; set; }
        public string ServiceProviderContact { get; set; }
        public string Cdoname { get; set; }
        public string Cdocontact { get; set; }
        public string Hhnin { get; set; }
        public int? AdministrationPhaseId { get; set; }
        public int? MaritalStatusId { get; set; }
        public int? HheducationLevelId { get; set; }
        public int? ExpensePaymentId { get; set; }
        public double? ExpensePaymentScore { get; set; }
        public int? IncomeSourceId { get; set; }
        public double? IncomeSourceScore { get; set; }
        public int? IsSavingsGroupMember { get; set; }
        public double? IsSavingsGroupMemberScore { get; set; }
        public int? SavingSchemeId { get; set; }
        public double? SavingSchemeScore { get; set; }
        public string MemberBenefitsId { get; set; }
        public double? MemberBenefitsScore { get; set; }
        public int? HouseHoldIncomeId { get; set; }
        public double? HouseHoldIncomeScore { get; set; }
        public string HhassetsId { get; set; }
        public double? HhassetsScore { get; set; }
        public string IncurredExpensesId { get; set; }
        public double? IncurredExpensesScore { get; set; }
        public double? EconomicStabilityTotal { get; set; }
        public int? FoodConsumedId { get; set; }
        public int? FoodConsumedScore { get; set; }
        public string FoodGroupId { get; set; }
        public double? FoodGroupScore { get; set; }
        public int? MealId { get; set; }
        public double? MealScore { get; set; }
        public int? LackofFood { get; set; }
        public double? LackofFoodScore { get; set; }
        public int? MalnutritionSignId { get; set; }
        public double? MalnutritionSignScore { get; set; }
        public string ApplicableOptionId { get; set; }
        public double? ApplicableOptionScore { get; set; }
        public int? HavePersonWithDisability { get; set; }
        public double? HavePersonWithDisabilityScore { get; set; }
        public int? HaveLongTermIllness { get; set; }
        public double? HaveLongTermIllnessScore { get; set; }
        public int? ReferredDisabilityId { get; set; }
        public double? ReferredDisabilityScore { get; set; }
        public int? KnownHivstatusId { get; set; }
        public double? KnownHivstatusScore { get; set; }
        public int? TreatmentId { get; set; }
        public double? TreatmentScore { get; set; }
        public int? TreatmentAdheranceId { get; set; }
        public double? TreatmentAdheranceScore { get; set; }
        public int? BloodTestId { get; set; }
        public double? BloodTestScore { get; set; }
        public int? HhviralLoadSuppresedId { get; set; }
        public double? HhviralLoadSuppresedScore { get; set; }
        public int? ShelterId { get; set; }
        public double? ShelterScore { get; set; }
        public double? SurvivalandHealthTotal { get; set; }
        public int? Childrenaged617enrolledInSchool { get; set; }
        public double? Childrenaged617enrolledInSchoolScore { get; set; }
        public int? Childrenaged617attendedInSchool { get; set; }
        public double? Childrenaged617attendedInSchoolScore { get; set; }
        public int? PreSchoolNotEnrolledId { get; set; }
        public double? PreSchoolNotEnrolledScore { get; set; }
        public int? ChildrenChildProgressing { get; set; }
        public double? ChildrenChildProgressingScore { get; set; }
        public string ProgressingReasonId { get; set; }
        public double? ProgressingReasonScore { get; set; }
        public double? EducationandDevelopmentTotal { get; set; }
        public int? SameAdultPrimaryCareGiver { get; set; }
        public double? SameAdultPrimaryCareGiverScore { get; set; }
        public int? ComplicationsId { get; set; }
        public double? ComplicationsScore { get; set; }
        public int? ChildAbuseId { get; set; }
        public double? ChildAbuseScore { get; set; }
        public int? OccuranceId { get; set; }
        public double? OccuranceScore { get; set; }
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

        public virtual AHhassessmentStatus AssessmentStatus { get; set; }
        public virtual AHhviralLoadBloodTest BloodTest { get; set; }
        public virtual AHhchildAbuse ChildAbuse { get; set; }
        public virtual AYesNo ChildrenChildProgressingNavigation { get; set; }
        public virtual AYesNo Childrenaged617attendedInSchoolNavigation { get; set; }
        public virtual AYesNo Childrenaged617enrolledInSchoolNavigation { get; set; }
        public virtual AHhchildrenComplications Complications { get; set; }
        public virtual ADistrict District { get; set; }
        public virtual AExpensePayment ExpensePayment { get; set; }
        public virtual AFoodConsumedSource FoodConsumed { get; set; }
        public virtual AYesNo HaveLongTermIllnessNavigation { get; set; }
        public virtual AYesNo HavePersonWithDisabilityNavigation { get; set; }
        public virtual AHheducationLevel HheducationLevel { get; set; }
        public virtual AHhviralLoadSuppressed HhviralLoadSuppresed { get; set; }
        public virtual BeneficiaryIdentificationRegister HouseHold { get; set; }
        public virtual AHhincome HouseHoldIncome { get; set; }
        public virtual AHhincomeSource IncomeSource { get; set; }
        public virtual AYesNo IsSavingsGroupMemberNavigation { get; set; }
        public virtual AHhknownHivstatus KnownHivstatus { get; set; }
        public virtual AYesNo LackofFoodNavigation { get; set; }
        public virtual AMalnutritionSigns MalnutritionSign { get; set; }
        public virtual AMaritalStatus MaritalStatus { get; set; }
        public virtual ADailyMeals Meal { get; set; }
        public virtual AChildAbuseOccurances Occurance { get; set; }
        public virtual AHhpreSchoolNotEnrolled PreSchoolNotEnrolled { get; set; }
        public virtual AReferredDisability ReferredDisability { get; set; }
        public virtual AYesNo SameAdultPrimaryCareGiverNavigation { get; set; }
        public virtual ASavingScheme SavingScheme { get; set; }
        public virtual AStableShelter Shelter { get; set; }
        public virtual ASubcounty Subcounty { get; set; }
        public virtual ATuberclosisTreatment Treatment { get; set; }
        public virtual AHhtreatmentAdherance TreatmentAdherance { get; set; }
    }
}
