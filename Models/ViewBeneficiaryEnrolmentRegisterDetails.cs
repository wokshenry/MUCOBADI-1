using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewBeneficiaryEnrolmentRegisterDetails
    {
        public string GenderDescription { get; set; }
        public int HouseHoldId { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public string HouseHoldMemberCode { get; set; }
        public string GenderId { get; set; }
        public string HouseHoldCode { get; set; }
        public DateTime? DateofIdentification { get; set; }
        public int? IdentificationId { get; set; }
        public string IdentificationDescription { get; set; }
        public string OtherIdentificationSource { get; set; }
        public string Surname { get; set; }
        public string GivenName { get; set; }
        public DateTime? DoB { get; set; }
        public int? Age { get; set; }
        public int? KnownRiskFactorId { get; set; }
        public string KnownRiskFactorDescription { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictDescription { get; set; }
        public int? SubcountyId { get; set; }
        public string SubcountyDescription { get; set; }
        public int? ParishId { get; set; }
        public string ParishDescription { get; set; }
        public int? VillageId { get; set; }
        public string VillageDescription { get; set; }
        public int? HivstatusId { get; set; }
        public string HivstatusDescription { get; set; }
        public int? FacilityId { get; set; }
        public string FacilityName { get; set; }
        public int? RegimenCategoryId { get; set; }
        public string RegimenCategoryDescription { get; set; }
        public int? RegimenId { get; set; }
        public string RegimenDescription { get; set; }
        public int? DispensingModelId { get; set; }
        public string DispensingModelDescription { get; set; }
        public int? CurrentlyonArt { get; set; }
        public DateTime? Cohort { get; set; }
        public string Artnumber { get; set; }
        public string Copies { get; set; }
        public int? ViralLoadSuppressedId { get; set; }
        public string ViralLoadSuppressedDescription { get; set; }
        public int? SourceDocumentId { get; set; }
        public string SourceDocumentDescription { get; set; }
        public string OtherSourceDocument { get; set; }
        public string SourceDocumentUrl { get; set; }
        public string SourceDocumentExt { get; set; }
        public DateTime? DateAdded { get; set; }
        public string AddedBy { get; set; }
        public string TelephoneContact { get; set; }
        public DateTime? VirallaodDate { get; set; }
        public string HouseHoldMemberSurname { get; set; }
        public string HouseHoldMemberGivenname { get; set; }
        public string HouseHoldMemberGenderId { get; set; }
        public string HouseHoldMemberGenderDescription { get; set; }
        public DateTime? HouseHoldMemberDoB { get; set; }
        public int? HouseHoldMemberAge { get; set; }
        public int? HouseHoldMemberKnownRiskFactorId { get; set; }
        public string HouseHoldMemberKnownRiskFactorDescription { get; set; }
        public int? ProgramParticipationId { get; set; }
        public string ProgramParticipationDescription { get; set; }
        public int? IsCareGiver { get; set; }
        public string CareGiverDesc { get; set; }
        public int? IsEnrolledInSchool { get; set; }
        public int? IsAttendingSchoolRegularly { get; set; }
        public int? EducationLevelId { get; set; }
        public string EducationLevelDescription { get; set; }
        public string NameofSchool { get; set; }
        public int? IsOrphaned { get; set; }
        public int? IsChildUnder5Malnourished { get; set; }
        public int? DoesChildHaveBirthCertificate { get; set; }
        public int? IsDisabled { get; set; }
        public string DisabilityDescription { get; set; }
        public int? Ischildimmunised { get; set; }
        public int? HouseHoldMemberHivstatusId { get; set; }
        public string HouseHoldMemberHivstatusDescription { get; set; }
        public int? HouseHoldMemberCurrentlyonArt { get; set; }
        public DateTime? HouseHoldMemberCohort { get; set; }
        public string HouseHoldMemberArtnumber { get; set; }
        public int? HasanIga { get; set; }
        public int? IsinSavingsGroup { get; set; }
        public int? Isinschoolcompletingapprenticeship { get; set; }
        public DateTime? EnrollmentDate { get; set; }
    }
}
