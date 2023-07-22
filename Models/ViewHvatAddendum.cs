using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewHvatAddendum
    {
        public int HvataddendumId { get; set; }
        public int Hvatid { get; set; }
        public int HouseHoldMemberId { get; set; }
        public string HouseHoldMemberCode { get; set; }
        public string Surname { get; set; }
        public string Givenname { get; set; }
        public DateTime? DoB { get; set; }
        public int? Age { get; set; }
        public string GenderId { get; set; }
        public string GenderDescription { get; set; }
        public int? CareGiverId { get; set; }
        public string CareGiverDesc { get; set; }
        public int? HouseHoldId { get; set; }
        public int? EducationLevelId { get; set; }
        public string EducationLevelDescription { get; set; }
        public string NameofSchool { get; set; }
        public int? IsOrphaned { get; set; }
        public string IsOphanedDesc { get; set; }
        public int? ChildUnderFiveMalnurished { get; set; }
        public string ChildUnderFiveMalnurishedDesc { get; set; }
        public int? ChildHasBirthCertificate { get; set; }
        public string ChildHasBirthCertificateDesc { get; set; }
        public int? IsChildImmunised { get; set; }
        public string IsChildImmunisedDesc { get; set; }
        public int? DisabilityId { get; set; }
        public string DisabilityDesc { get; set; }
        public int? HivstatusId { get; set; }
        public string HivstatusDescription { get; set; }
        public int? IsCurrentlyOnArt { get; set; }
        public string IsCurrentlyOnArtDesc { get; set; }
        public int? CompletedFinancialLiteracy { get; set; }
        public string CompletedFinancialLiteracyDesc { get; set; }
        public int? HasIga { get; set; }
        public string HasIgadesc { get; set; }
        public int? IsInSavingGroup { get; set; }
        public string IsInSavingGroupDesc { get; set; }
        public int? CompletingApprenticeshipOrInSchool { get; set; }
        public string CompletingApprenticeshipOrInSchoolDesc { get; set; }
        public int? SchoolEnrolmentId { get; set; }
        public string SchoolEnrolmentDesc { get; set; }
        public int? AttendsSchoolRegulary { get; set; }
        public string AttendsSchoolRegularyDesc { get; set; }
        public int? KnownRiskFactorId { get; set; }
        public string KnownRiskFactorDescription { get; set; }
        public int? ProgramParticipationId { get; set; }
        public string ProgramParticipationDescription { get; set; }
    }
}
