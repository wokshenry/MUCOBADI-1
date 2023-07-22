using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class HivTbTrackingFormExposedInfants
    {
        public int HivTbTrackingFormExposedInfantsId { get; set; }
        public int? HivTbTrackingFormId { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public int? RegistrationStatusId { get; set; }
        public int? SupportedToEnrollAndAdhereToPmtct { get; set; }
        public string PcrTestId { get; set; }
        public int? PmtctmotherProvidedWithTreatmentLiteracy { get; set; }
        public int? EidCascadeId { get; set; }
        public string EidCascadeTransferred { get; set; }
        public int? IsEnrolledOnArt { get; set; }
        public string ArtNumber { get; set; }
        public int? IsTrackedAndReturnedToCare { get; set; }
        public int? FeedingStatusId { get; set; }
        public string ExposedInfantsNo { get; set; }

        public virtual AEidCascade EidCascade { get; set; }
        public virtual AFeedingStatus FeedingStatus { get; set; }
        public virtual HivTbTrackingForm HivTbTrackingForm { get; set; }
        public virtual HouseHoldMembers HouseHoldMember { get; set; }
        public virtual AYesNo IsEnrolledOnArtNavigation { get; set; }
        public virtual AYesNo IsTrackedAndReturnedToCareNavigation { get; set; }
        public virtual AYesNo PmtctmotherProvidedWithTreatmentLiteracyNavigation { get; set; }
        public virtual ARegistrationStatus RegistrationStatus { get; set; }
        public virtual AYesNo SupportedToEnrollAndAdhereToPmtctNavigation { get; set; }
    }
}
