using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AContacts
    {
        public int ContactId { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactMiddleName { get; set; }
        public string ContactLastName { get; set; }
        public string GenderId { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhoneNumber { get; set; }
        public int? CountryId { get; set; }
        public string OperationDistrict { get; set; }
        public string OperationSubCounty { get; set; }
        public int? FacilityId { get; set; }
        public int? ServiceProviderId { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public int? PositionId { get; set; }

        public virtual ACountry Country { get; set; }
        public virtual AFacility Facility { get; set; }
        public virtual AGender Gender { get; set; }
        public virtual APosition Position { get; set; }
        public virtual AServiceProvider ServiceProvider { get; set; }
    }
}
