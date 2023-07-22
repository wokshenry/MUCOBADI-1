using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewIsCareGiver
    {
        public int? HouseHoldId { get; set; }
        public string HouseHoldCode { get; set; }
        public int HouseHoldMemberId { get; set; }
        public string HouseHoldMemberCode { get; set; }
        public string Surname { get; set; }
        public string Givenname { get; set; }
        public string GenderId { get; set; }
        public DateTime? DoB { get; set; }
        public int? Age { get; set; }
        public int? KnownRiskFactorId { get; set; }
        public int? ProgramParticipationId { get; set; }
        public int? IsCareGiver { get; set; }
        public int? IsEnrolledInSchool { get; set; }
        public int? IsAttendingSchoolRegularly { get; set; }
        public int? EducationLevelId { get; set; }
        public string NameofSchool { get; set; }
        public int? IsOrphaned { get; set; }
        public int? IsChildUnder5Malnourished { get; set; }
        public int? DoesChildHaveBirthCertificate { get; set; }
        public int? IsDisabled { get; set; }
        public string DisabilityDescription { get; set; }
        public int? Ischildimmunised { get; set; }
        public int? HivstatusId { get; set; }
        public int? CurrentlyonArt { get; set; }
        public DateTime? Cohort { get; set; }
        public string Artnumber { get; set; }
        public int? HasanIga { get; set; }
        public int? IsinSavingsGroup { get; set; }
        public int? Isinschoolcompletingapprenticeship { get; set; }
        public DateTime? EnrollmentDate { get; set; }
    }
}
