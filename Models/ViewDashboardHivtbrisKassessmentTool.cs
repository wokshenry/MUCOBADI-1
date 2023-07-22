using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewDashboardHivtbrisKassessmentTool
    {
        public int TbriskAssessmentId { get; set; }
        public string HouseHoldCode { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public int? ParishId { get; set; }
        public int? VillageId { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public int? HivstatusId { get; set; }
        public int? IsOnArt { get; set; }
        public string ArtNumber { get; set; }
        public int? IsVirallaodTestDone { get; set; }
        public int? ViralLoadLevelId { get; set; }
        public int? ClientHadUnprotectedSexInPastThreeMonth { get; set; }
        public int? ClientFallsInSexWorkersCategory { get; set; }
        public int? HivnegativePartnerInDiscordantRelationship { get; set; }
        public int? ClientWithSexuallyTransmittedInfection { get; set; }
        public int? ClientHasPresumptiveActiveTbdisease { get; set; }
        public int? ClientHasNewHepatitisBdiagnosis { get; set; }
        public int? ClientHasHistoryOfIllness { get; set; }
        public int? ClientHasLossOfSexualPartnerHistory { get; set; }
        public int? ClientIsMaleOrFemaleWithnoHivtest { get; set; }
        public int? BeenCoughingForTwoWeek { get; set; }
        public int? PersistentFeverForTwoWeeks { get; set; }
        public int? HaveYouLostWeight { get; set; }
        public int? ExperiencedExcessiveNightSweats { get; set; }
        public int? ChildCoughingForTwoWeeks { get; set; }
        public int? ChildHadPersistentFeverHstory { get; set; }
        public int? ChildHasPoorWeightGain { get; set; }
        public int? ChildHadContactWithActiveTbdiseaseAdult { get; set; }
        public int? ChildExperiencedExcessiveNightSweeting { get; set; }
        public int? ChildAdmittedToHospitalInSixMonths { get; set; }
        public int? ChildLivesWithHivpositiveMotherOrFather { get; set; }
        public int? ChildHivsymptomatic { get; set; }
        public int? ChildMalnourished { get; set; }
        public int? ChildDignosedWithTuberculosis { get; set; }
        public int? ChildHasSexualAbuseHistory { get; set; }
        public int? ChildHasAccidentalExposure { get; set; }
        public int? ChildDrugAbuseOrAlcohol { get; set; }
        public string DistrictDescription { get; set; }
        public string SubcountyDescription { get; set; }
        public string ParishDescription { get; set; }
        public string VillageDescription { get; set; }
        public int? Age { get; set; }
        public DateTime? DoB { get; set; }
        public int? CalculatedAge { get; set; }
    }
}
