using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViralLoadUpload3
    {
        public string HhUiD { get; set; }
        public int? HouseHoldId { get; set; }
        public DateTime? DateOfFollowUp { get; set; }
        public string IndividualUiD { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public string HivStatusAfterFollowUp { get; set; }
        public string IfHivOnArt { get; set; }
        public DateTime? ArtCohort { get; set; }
        public double? ArtNo { get; set; }
        public string ClientMemberStatusOnArt { get; set; }
        public string ClientsClassification { get; set; }
        public double? WeightInKgs { get; set; }
        public int? FacilityId { get; set; }
        public double? DurationOnTreatmentInMonths { get; set; }
        public string ClientLineOfTreatment { get; set; }
        public string ClientArtRegimen { get; set; }
        public string ModalityOfCareAndTreatment { get; set; }
        public string ModalityOfDrugDispensing { get; set; }
        public int? SubcountyId { get; set; }
        public int? DistrictId { get; set; }
        public DateTime? LastArtAppointmnetDate { get; set; }
        public DateTime? NextArtAppointmentDate { get; set; }
        public string IsClientEligibleForViralLoad { get; set; }
        public int? ViralLoadTestDoneId { get; set; }
        public int? ViralLoadtestresultsreceivedId { get; set; }
        public string ViralLoadTestCopiesMl { get; set; }
        public string ViralLoadResults { get; set; }
        public DateTime? DateWhenLastVlTestWasDone { get; set; }
        public DateTime? DateWhenNextVlWillBeDne { get; set; }
        public string DoesTheClientHaveAPresumptiveOrActiveTbDisease { get; set; }
        public string HasTheClientReceivedATbScreeningSession { get; set; }
        public string ClientIsAtRiskOfTbInfection { get; set; }
        public string ClientReferredAndTestedForTb { get; set; }
        public string ClientTbTestResults { get; set; }
        public string IfClientReturnedAPositiveResultOnTbTreatment { get; set; }
        public string DurationOnTbTreatment { get; set; }
        public string IfClientReturnedANegativeResultOnTbPreventiveTreatment { get; set; }
        public double? DurationOnTptTreatment { get; set; }
        public string MeansOfFollowUp { get; set; }
        public int? ClientsuccessfullycontactedId { get; set; }
        public int? AnyoneelsecontactedId { get; set; }
        public string IfYesWhoWasContactedAFamilyMemberBTreatmentSuppo { get; set; }
        public string Servicesprovided { get; set; }
        public string NotSuppressingReason { get; set; }
        public string NonAdheranceReason { get; set; }
        public string IfYesToOthersSpecifyReasonHere { get; set; }
        public string _11NextActionToBeTakenBySocialWorkerBasedOnCarePlan { get; set; }
        public string NameOfSocialWorker { get; set; }
        public string Title { get; set; }
        public string SocialWorkerTel { get; set; }
        public string ReviewedBy { get; set; }
        public string Title1 { get; set; }
        public string ReviewDate { get; set; }
        public string DataEnteredBy { get; set; }
    }
}
