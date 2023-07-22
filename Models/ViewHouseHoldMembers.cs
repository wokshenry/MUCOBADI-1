using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewHouseHoldMembers
    {
        public int HouseHoldId { get; set; }
        public string HouseHoldCode { get; set; }
        public int HouseHoldMemberId { get; set; }
        public string HouseHoldMemberCode { get; set; }
        public string Surname { get; set; }
        public string Givenname { get; set; }
        public string FullName { get; set; }
        public string GenderId { get; set; }
        public string GenderDescription { get; set; }
        public DateTime? DoB { get; set; }
        public int? Age { get; set; }
        public int? KnownRiskFactorId { get; set; }
        public string KnownRiskFactorDescription { get; set; }
        public int? ProgramParticipationId { get; set; }
        public string ProgramParticipationDescription { get; set; }
        public int? IsCareGiver { get; set; }
        public int? IsEnrolledInSchool { get; set; }
        public int? IsAttendingSchoolRegularly { get; set; }
        public int? HivstatusId { get; set; }
        public string HivstatusDescription { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public int? CurrentlyonArt { get; set; }
        public DateTime? Cohort { get; set; }
        public string Artnumber { get; set; }
    }
}
