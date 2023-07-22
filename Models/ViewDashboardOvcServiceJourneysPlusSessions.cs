using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewDashboardOvcServiceJourneysPlusSessions
    {
        public int? VslaGroupDirectMemberId { get; set; }
        public int? NoSessions { get; set; }
        public int? CurriculumId { get; set; }
        public DateTime? DoB { get; set; }
        public string GenderId { get; set; }
        public string GenderDescription { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictDescription { get; set; }
        public int? SubcountyId { get; set; }
        public string SubcountyDescription { get; set; }
        public decimal? CurriculumCalculation { get; set; }
        public int Attended80Percent { get; set; }
        public int? ActualAge { get; set; }
        public string AgeCategory { get; set; }
    }
}
