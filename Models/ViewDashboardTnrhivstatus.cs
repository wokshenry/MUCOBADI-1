using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewDashboardTnrhivstatus
    {
        public int? HouseHoldMemberId { get; set; }
        public int? HivstatusId { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictDescription { get; set; }
        public int? SubcountyId { get; set; }
        public string SubcountyDescription { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public int? Qtr { get; set; }
        public int? VisitationYear { get; set; }
        public string AgeCategory { get; set; }
        public int? IsCareGiver { get; set; }
    }
}
