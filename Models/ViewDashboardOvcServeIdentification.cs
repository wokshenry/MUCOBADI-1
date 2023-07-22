using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewDashboardOvcServeIdentification
    {
        public int HouseHoldId { get; set; }
        public int? ProgramParticipationId { get; set; }
        public string ProgramParticipationDescription { get; set; }
        public DateTime? VisitationDate { get; set; }
        public int? VisitationMonth { get; set; }
        public int? VisitationYear { get; set; }
        public string HouseHoldCode { get; set; }
        public DateTime? DateofIdentification { get; set; }
        public int? IdentificationId { get; set; }
        public string OtherIdentificationSource { get; set; }
        public string Surname { get; set; }
        public string GivenName { get; set; }
        public string GenderId { get; set; }
        public string GenderDescription { get; set; }
        public DateTime? DoB { get; set; }
        public int? ActualAge { get; set; }
        public string AgeCategory { get; set; }
        public string AgeBands { get; set; }
        public int? ParishId { get; set; }
        public int? VillageId { get; set; }
        public int HivstatusId { get; set; }
        public int? FacilityId { get; set; }
        public int? RegimenCategoryId { get; set; }
        public int? RegimenId { get; set; }
        public int? DispensingModelId { get; set; }
        public int? CurrentlyonArt { get; set; }
        public DateTime? Cohort { get; set; }
        public string Artnumber { get; set; }
        public string Copies { get; set; }
        public int? ViralLoadSuppressedId { get; set; }
        public int? SourceDocumentId { get; set; }
        public string OtherSourceDocument { get; set; }
        public string SourceDocumentUrl { get; set; }
        public string SourceDocumentExt { get; set; }
        public DateTime? DateAdded { get; set; }
        public string AddedBy { get; set; }
        public string TelephoneContact { get; set; }
        public DateTime? VirallaodDate { get; set; }
        public int? OvcVlrId { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictDescription { get; set; }
        public int? SubcountyId { get; set; }
        public string SubcountyDescription { get; set; }
        public int? KnownRiskFactorId { get; set; }
        public string KnownRiskFactorDescription { get; set; }
        public string HivstatusDescription { get; set; }
    }
}
