using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class BeneficiaryIdentificationRegisterUpload
    {
        public string HhUiD { get; set; }
        public string District { get; set; }
        public int DistrictId { get; set; }
        public string SubCounty { get; set; }
        public int SubcountyId { get; set; }
        public string Parish { get; set; }
        public string Village { get; set; }
        public string NameOfHhHead { get; set; }
        public string TelContactOfHhHead { get; set; }
        public string NameOfServiceProvider { get; set; }
        public string TelContactOfServiceProvider { get; set; }
        public string NameOfSubCountyCdo { get; set; }
        public string TelContactOfSubCountyCdo { get; set; }
        public double? AgeOfHhHead { get; set; }
        public string PhaseOfAdministration { get; set; }
        public string SexOfHeadOfHh { get; set; }
        public string MaritalStatusOfHhHead { get; set; }
        public string EducationLevelOfHhHead { get; set; }
    }
}
