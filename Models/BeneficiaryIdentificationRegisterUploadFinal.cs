using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class BeneficiaryIdentificationRegisterUploadFinal
    {
        public string HhUiD { get; set; }
        public int DistrictId { get; set; }
        public int SubcountyId { get; set; }
        public int? ParishId { get; set; }
        public int? VillageId { get; set; }
        public string NameOfHhHead { get; set; }
        public string TelContactOfHhHead { get; set; }
        public int? NameOfServiceProvider { get; set; }
        public string TelContactOfServiceProvider { get; set; }
        public string NameOfSubCountyCdo { get; set; }
        public string TelContactOfSubCountyCdo { get; set; }
        public int? AgeOfHhHead { get; set; }
        public int? PhaseOfAdministration { get; set; }
        public string SexOfHeadOfHh { get; set; }
        public int? MaritalStatusOfHhHead { get; set; }
        public int? EducationLevelOfHhHead { get; set; }
    }
}
