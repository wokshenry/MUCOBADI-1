using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class GraduationBenchMark
    {
        public GraduationBenchMark()
        {
            GraduationBenchMarkDetail = new HashSet<GraduationBenchMarkDetail>();
        }

        public int GraduationBenchMarkId { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public int? ImplementingPartnerId { get; set; }
        public int? DistrictId { get; set; }
        public int? SubCountyId { get; set; }
        public int? ParishId { get; set; }
        public int? VillageId { get; set; }
        public string AdministeringPersonName { get; set; }
        public string AdministeringPersonPhoneNumber { get; set; }
        public int? HouseholdId { get; set; }
        public int? KnownHiveStatusAssessmentYesNoId { get; set; }
        public int? VirallySuppressedAssessmentYesNoId { get; set; }
        public int? HivpreventionKnowledgeAssessmentYesNoId { get; set; }
        public int? NotundernourishedAssessmentYesNoId { get; set; }
        public int? ImprovedfinancialstabilityAssessmentYesNoId { get; set; }
        public int? ImprovedfinancialstabilityScholashipYesNoId { get; set; }
        public int? ImprovedfinancialstabilitySellingIncomeGeneratingSomethingYesNoId { get; set; }
        public int? MedicalCostAssessmentYesNoId { get; set; }
        public int? MedicalCostCashTransfertYesNoId { get; set; }
        public int? MedicalCostSellingIncomeGeneratingSomethingYesNoId { get; set; }
        public int? NoViolenceAssesmentYesNoId { get; set; }
        public int? ChildHeadedHouseholdAssessmentYesNoId { get; set; }
        public int? ChildrenInSchoolAssessmentYesNoId { get; set; }
        public string GeneralComment { get; set; }
        public int? HouseholdStatusId { get; set; }
        public string NameofAssessor { get; set; }
        public string AssessorTitle { get; set; }
        public string AssessorCode { get; set; }

        public virtual AYesNo ChildHeadedHouseholdAssessmentYesNo { get; set; }
        public virtual AYesNo ChildrenInSchoolAssessmentYesNo { get; set; }
        public virtual ADistrict District { get; set; }
        public virtual AYesNo HivpreventionKnowledgeAssessmentYesNo { get; set; }
        public virtual BeneficiaryIdentificationRegister Household { get; set; }
        public virtual AEnrolledHouseholdStatus HouseholdStatus { get; set; }
        public virtual AImplementingPartner ImplementingPartner { get; set; }
        public virtual AYesNo ImprovedfinancialstabilityAssessmentYesNo { get; set; }
        public virtual AYesNo ImprovedfinancialstabilityScholashipYesNo { get; set; }
        public virtual AYesNo ImprovedfinancialstabilitySellingIncomeGeneratingSomethingYesNo { get; set; }
        public virtual AYesNo KnownHiveStatusAssessmentYesNo { get; set; }
        public virtual AYesNo MedicalCostAssessmentYesNo { get; set; }
        public virtual AYesNo MedicalCostCashTransfertYesNo { get; set; }
        public virtual AYesNo MedicalCostSellingIncomeGeneratingSomethingYesNo { get; set; }
        public virtual AYesNo NoViolenceAssesmentYesNo { get; set; }
        public virtual AYesNo NotundernourishedAssessmentYesNo { get; set; }
        public virtual AParish Parish { get; set; }
        public virtual ASubcounty SubCounty { get; set; }
        public virtual AVillage Village { get; set; }
        public virtual AYesNo VirallySuppressedAssessmentYesNo { get; set; }
        public virtual ICollection<GraduationBenchMarkDetail> GraduationBenchMarkDetail { get; set; }
    }
}
