using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class HivTbTrackingFormUpload
    {
        public string District { get; set; }
        public string SubCounty { get; set; }
        public string Parish { get; set; }
        public string Village { get; set; }
        public DateTime? DateOfFollowUp { get; set; }
        public string HhCode { get; set; }
        public string IndividualUniqueIdentifier { get; set; }
        public string NameOfIndividual { get; set; }
        public double? AgeOfIndividual { get; set; }
        public string Gender { get; set; }
        public double? TelContact { get; set; }
        public string HivStatusAfterFollowUp { get; set; }
        public string IfHivOnArt { get; set; }
        public double? ArtCohort { get; set; }
        public double? ArtNo { get; set; }
        public string ClientMemberStatusOnArt { get; set; }
        public double? ClientsClassification { get; set; }
        public double? WeightInKgs { get; set; }
        public double? IfTransferredOutToWhere { get; set; }
        public string HealthFacilityForCareTreatment { get; set; }
        public string ArtNoHealthFacilityForCareAndTreatment { get; set; }
        public double? DurationOnTreatmentInMonths { get; set; }
        public string ClientLineOfTreatment { get; set; }
        public double? ClientArtRegimen { get; set; }
        public string ModalityOfCareAndTreatment { get; set; }
        public string ModalityOfDrugDispensing { get; set; }
        public string SubcountyForCareAndTreatment { get; set; }
        public string DistrictOfCurrentCarePoint { get; set; }
        public DateTime? LastArtAppointmnetDate { get; set; }
        public DateTime? NextArtAppointmentDate { get; set; }
        public string IsClientEligibleForViralLoad { get; set; }
        public string ViralLoadTestDoneYN { get; set; }
        public string ViralLoadTestResultsReceivedYN { get; set; }
        public string ViralLoadTestCopiesMl { get; set; }
        public string ViralLoadResults { get; set; }
        public DateTime? DateWhenLastVlTestWasDone { get; set; }
        public DateTime? DateWhenNextVlWillBeDne { get; set; }
        public double? DoesTheClientHaveAPresumptiveOrActiveTbDisease { get; set; }
        public double? HasTheClientReceivedATbScreeningSession { get; set; }
        public double? ClientIsAtRiskOfTbInfection { get; set; }
        public double? ClientReferredAndTestedForTb { get; set; }
        public double? ClientTbTestResults { get; set; }
        public double? IfClientReturnedAPositiveResultOnTbTreatment { get; set; }
        public double? DurationOnTbTreatment { get; set; }
        public double? IfClientReturnedANegativeResultOnTbPreventiveTreatment { get; set; }
        public double? DurationOnTptTreatment { get; set; }
        public string MeansOfFollowUp { get; set; }
        public string WasTheClientSuccessfullyContactedSeenAYesBNo { get; set; }
        public double? IfNotContactedWasAnyoneElseContactedOnBehalfOfTheCli { get; set; }
        public double? IfYesWhoWasContactedAFamilyMemberBTreatmentSuppo { get; set; }
        public double? _9aIntensiveAdherenceCounselingIac { get; set; }
        public double? _9bLinkageToArtServices { get; set; }
        public double? _9cLinkageToPeerSupportGroupsForYoungPositives { get; set; }
        public double? _9dNutritionEducationAndSupport { get; set; }
        public double? _9eCompletedReferralForServicesIncludingCareAndTreatment { get; set; }
        public double? _9fTransportFacilitation { get; set; }
        public double? _9gTemporaryConsumptionSupport { get; set; }
        public double? _9hPsychosocialSupport { get; set; }
        public double? _9iSupportedToReceiveViralLoadTest { get; set; }
        public double? _10ADrugResistance { get; set; }
        public double? _10B1PillBurdenTreatmentFatigue { get; set; }
        public double? _10B2LackOfFood { get; set; }
        public double? _10B3SideEffects { get; set; }
        public double? _10B4ForgetToTake { get; set; }
        public double? _10B5NonDisclosureOfStatus { get; set; }
        public double? _10B6StigmaAndDiscrimination { get; set; }
        public double? _10B7LowSelfEsteem { get; set; }
        public double? _10B8PovertyLackOfBasicResources { get; set; }
        public double? _10B9PeerPressure { get; set; }
        public double? _10B10Depression { get; set; }
        public double? _10B11SubstanceAbuse { get; set; }
        public double? _10B12Gbv { get; set; }
        public double? _10B13OthersSpecify { get; set; }
        public double? IfYesToOthersSpecifyReasonHere { get; set; }
        public double? _11NextActionToBeTakenBySocialWorkerBasedOnCarePlan { get; set; }
        public string NameOfSocialWorker { get; set; }
        public string Title { get; set; }
        public string HouseholdCode { get; set; }
        public string DistrictOfChild { get; set; }
        public string SubCountyOfChild { get; set; }
        public string ParishOfChild { get; set; }
        public string VillageOfChild { get; set; }
        public string DateOfFollowUp1 { get; set; }
        public string PmtctMotherIndividualUiD { get; set; }
        public string PmtctMotherSName { get; set; }
        public string PmtctMotherSAge { get; set; }
        public string PmtctMotherCurrentlyOnArt { get; set; }
        public string ArtNumber { get; set; }
        public string HealthFacilityForCare { get; set; }
        public string ExposedInfantsNo { get; set; }
        public string HeiSIndividualId { get; set; }
        public string NameOfHei { get; set; }
        public string HeiSDateOfBirth { get; set; }
        public string HeiSAgeInMonths { get; set; }
        public string SexOfHei { get; set; }
        public string DateOfRegistration { get; set; }
        public string RegistrationStatus { get; set; }
        public string HasClientBeenSupportedToEnrollAndAdhereToPmtct { get; set; }
        public string HasHeiBeenReferredForPcrTest { get; set; }
        public string AgeInMonthsAtPcrTest { get; set; }
        public string HasPmtctMotherBeenProvidedWithTreatmentLiteracy { get; set; }
        public string HasHeiCompletedEidCascadeAndGraduatedOffPmtct { get; set; }
        public string IfHeiWasTransferredToWhere { get; set; }
        public string IfDischargedPosHasHeiBeenEnrolledOnArt { get; set; }
        public string IfYesArtNoFacility { get; set; }
        public string IfNoHasHeiBeenTrackedAndReturnedToCare { get; set; }
        public string HeiFeedingStatus { get; set; }
    }
}
