using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class HomevisitUploadFinal
    {
        public string HhUiD { get; set; }
        public int? HouseHoldId { get; set; }
        public string District { get; set; }
        public int? DistrictId { get; set; }
        public string SubCounty { get; set; }
        public int? SubcountyId { get; set; }
        public string Parish { get; set; }
        public int? ParishId { get; set; }
        public string Village { get; set; }
        public int? VillageId { get; set; }
        public DateTime? DateOfVisit { get; set; }
        public string UiDOfPersonTalkedToDuringVisit { get; set; }
        public int? UiDOfPersonTalkedToDuringVisitCode { get; set; }
        public string ReasonForVisitToEnrolledHh { get; set; }
        public string ProgramParticipationStatusOfEnrolledHh { get; set; }
        public string IndividualUiD { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public string NameOfIndividualEnrolled { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public double? AgeOfIndividual { get; set; }
        public string SexOfIndividual { get; set; }
        public string BeneficiaryProgramParticipationStatus { get; set; }
        public string AdjustedRiskFactor { get; set; }
        public string Stable { get; set; }
        public string Schooled { get; set; }
        public string Safe { get; set; }
        public string Health { get; set; }
    }
}
