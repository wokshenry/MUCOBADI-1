using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class OvcSchoolAttendencyHeader
    {
        public OvcSchoolAttendencyHeader()
        {
            OvcSchoolAttendencyDetails = new HashSet<OvcSchoolAttendencyDetails>();
        }

        public int SchoolAttendencyHeaderId { get; set; }
        public int? HouseHoldId { get; set; }
        public string Csoname { get; set; }
        public string OfficeName { get; set; }
        public DateTime? DatacollectionDate { get; set; }
        public int? DistrictId { get; set; }
        public int? SubcountyId { get; set; }
        public int? TermId { get; set; }
        public string SubmittedBy { get; set; }
        public string SubmittedByTitle { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public string ReviewedBy { get; set; }
        public string ReviewedByTitle { get; set; }
        public DateTime? ReviewDate { get; set; }

        public virtual ADistrict District { get; set; }
        public virtual BeneficiaryIdentificationRegister HouseHold { get; set; }
        public virtual ASubcounty Subcounty { get; set; }
        public virtual ATerm Term { get; set; }
        public virtual ICollection<OvcSchoolAttendencyDetails> OvcSchoolAttendencyDetails { get; set; }
    }
}
