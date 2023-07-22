using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class HivTbRisKassessmentTool
    {
        public int TbriskAssessmentId { get; set; }
        public int? TbriskAssessmentHeaderId { get; set; }
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
        public int? ChildAdmittedToHospitalInSixMonths { get; set; }
        public int? ChildLivesWithHivpositiveMotherOrFather { get; set; }
        public int? ChildHivsymptomatic { get; set; }
        public int? ChildMalnourished { get; set; }
        public int? ChildDignosedWithTuberculosis { get; set; }
        public int? ChildHasSexualAbuseHistory { get; set; }
        public int? ChildHasAccidentalExposure { get; set; }
        public int? ChildDrugAbuseOrAlcohol { get; set; }
        public int? ChildCoughingForTwoWeeks { get; set; }
        public int? ChildHadPersistentFeverHstory { get; set; }
        public int? ChildHasPoorWeightGain { get; set; }
        public int? ChildHadContactWithActiveTbdiseaseAdult { get; set; }
        public int? ChildExperiencedExcessiveNightSweeting { get; set; }

        public virtual AYesNo BeenCoughingForTwoWeekNavigation { get; set; }
        public virtual AYesNo ChildAdmittedToHospitalInSixMonthsNavigation { get; set; }
        public virtual AYesNo ChildCoughingForTwoWeeksNavigation { get; set; }
        public virtual AYesNo ChildDignosedWithTuberculosisNavigation { get; set; }
        public virtual AYesNo ChildDrugAbuseOrAlcoholNavigation { get; set; }
        public virtual AYesNo ChildExperiencedExcessiveNightSweetingNavigation { get; set; }
        public virtual AYesNo ChildHadContactWithActiveTbdiseaseAdultNavigation { get; set; }
        public virtual AYesNo ChildHadPersistentFeverHstoryNavigation { get; set; }
        public virtual AYesNo ChildHasAccidentalExposureNavigation { get; set; }
        public virtual AYesNo ChildHasPoorWeightGainNavigation { get; set; }
        public virtual AYesNo ChildHasSexualAbuseHistoryNavigation { get; set; }
        public virtual AYesNo ChildHivsymptomaticNavigation { get; set; }
        public virtual AYesNo ChildLivesWithHivpositiveMotherOrFatherNavigation { get; set; }
        public virtual AYesNo ChildMalnourishedNavigation { get; set; }
        public virtual AYesNo ClientFallsInSexWorkersCategoryNavigation { get; set; }
        public virtual AYesNo ClientHadUnprotectedSexInPastThreeMonthNavigation { get; set; }
        public virtual AYesNo ClientHasHistoryOfIllnessNavigation { get; set; }
        public virtual AYesNo ClientHasLossOfSexualPartnerHistoryNavigation { get; set; }
        public virtual AYesNo ClientHasNewHepatitisBdiagnosisNavigation { get; set; }
        public virtual AYesNo ClientHasPresumptiveActiveTbdiseaseNavigation { get; set; }
        public virtual AYesNo ClientIsMaleOrFemaleWithnoHivtestNavigation { get; set; }
        public virtual AYesNo ClientWithSexuallyTransmittedInfectionNavigation { get; set; }
        public virtual AYesNo ExperiencedExcessiveNightSweatsNavigation { get; set; }
        public virtual AYesNo HaveYouLostWeightNavigation { get; set; }
        public virtual AYesNo HivnegativePartnerInDiscordantRelationshipNavigation { get; set; }
        public virtual AHivstatus Hivstatus { get; set; }
        public virtual HouseHoldMembers HouseHoldMember { get; set; }
        public virtual AYesNo IsOnArtNavigation { get; set; }
        public virtual AYesNo IsVirallaodTestDoneNavigation { get; set; }
        public virtual AYesNo PersistentFeverForTwoWeeksNavigation { get; set; }
        public virtual HivTbRisKassessmentToolHeader TbriskAssessmentHeader { get; set; }
        public virtual AViralLoadLevel ViralLoadLevel { get; set; }
    }
}
