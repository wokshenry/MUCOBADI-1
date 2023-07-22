using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ReferralForm
    {
        public int ReferralFormId { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public int? HouseHoldId { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public string SerialNo { get; set; }
        public string ReferringAgencyName { get; set; }
        public string ReferringAgencyLocation { get; set; }
        public string ReferringAgencyPhoneNumber { get; set; }
        public string ReferringAgencyEmail { get; set; }
        public string CaseNatureReportedId { get; set; }
        public DateTime? DateofOccurancy { get; set; }
        public string OtherRisk { get; set; }
        public int? HasCaseBeenReportedToUgandaChildHelpline { get; set; }
        public string CaseNumber { get; set; }
        public string NameOfPersonAccompanyingTheChild { get; set; }
        public string PhoneNumberOfPersonAccompanyingTheChild { get; set; }
        public string ResidenceOfPersonAccompanyingTheChild { get; set; }
        public string EmailOfPersonAccompanyingTheChild { get; set; }
        public int? RelationshipToChild { get; set; }
        public int? CareGiverHouseHoldMemberId { get; set; }
        public string ServicesProvidedBeforeReferal { get; set; }
        public string ReasonForReferral { get; set; }
        public string DocumentsSupportingReferralEnclosed { get; set; }
        public string ConsentName { get; set; }
        public string ReferredToAgencyName { get; set; }
        public string ReferredToAgencyLocation { get; set; }
        public string ReferredToAgencyContactPersonName { get; set; }
        public string ReferredToAgencyPhoneNumber { get; set; }
        public string ReferredToAgencyEmail { get; set; }
        public string CaseWorkerReferringChildName { get; set; }
        public string CaseWorkerReferringChildTitle { get; set; }
        public string CaseWorkerReferringChildPhoneNumber { get; set; }
        public string CaseWorkerReferringChildEmail { get; set; }
        public DateTime? CaseWorkerReferringChildDate { get; set; }
        public string ServicePointCaseNo { get; set; }
        public DateTime? ServicePointArrivalDate { get; set; }
        public string ServicePointAgencyName { get; set; }
        public string ServicePointContactPerson { get; set; }
        public string ServicePointServicesProvided { get; set; }
        public string ServicePointAdditionalServicesRequired { get; set; }
        public string ServicePointPersonPrividingFeedbackName { get; set; }
        public string ServicePointPersonPrividingFeedbackTitle { get; set; }
        public string ServicePointPersonPrividingFeedbackPhoneNumber { get; set; }
        public string ServicePointPersonPrividingFeedbackEmail { get; set; }
        public DateTime? ServicePointPersonPrividingFeedbackDate { get; set; }
        public int? HivstatusId { get; set; }
        public int? CurrentlyonArt { get; set; }
        public string ArtNumber { get; set; }
        public DateTime? Cohort { get; set; }

        public virtual HouseHoldMembers CareGiverHouseHoldMember { get; set; }
        public virtual AYesNo CurrentlyonArtNavigation { get; set; }
        public virtual ADistrict District { get; set; }
        public virtual AYesNo HasCaseBeenReportedToUgandaChildHelplineNavigation { get; set; }
        public virtual AHivstatus Hivstatus { get; set; }
        public virtual BeneficiaryIdentificationRegister HouseHold { get; set; }
        public virtual HouseHoldMembers HouseHoldMember { get; set; }
        public virtual ARelationship RelationshipToChildNavigation { get; set; }
        public virtual ASubcounty Subcounty { get; set; }
    }
}
