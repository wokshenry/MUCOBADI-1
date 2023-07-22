using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewDashboardOvcHivHei
    {
        public int HivTbTrackingFormExposedInfantsId { get; set; }
        public int? HivTbTrackingFormId { get; set; }
        public int? HouseHoldMemberId { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public int? RegistrationStatusId { get; set; }
        public int? SupportedToEnrollAndAdhereToPmtct { get; set; }
        public string PcrTestId { get; set; }
        public string PcrtestDesc { get; set; }
        public int? PmtctmotherProvidedWithTreatmentLiteracy { get; set; }
        public int? EidCascadeId { get; set; }
        public string EidCascadeTransferred { get; set; }
        public int? IsEnrolledOnArt { get; set; }
        public string ArtNumber { get; set; }
        public int? IsTrackedAndReturnedToCare { get; set; }
        public int? FeedingStatusId { get; set; }
        public string ExposedInfantsNo { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictDescription { get; set; }
        public int? SubcountyId { get; set; }
        public string SubcountyDescription { get; set; }
        public int? HivstatusId { get; set; }
        public string HivstatusDescription { get; set; }
    }
}
