using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class ViewUserManagement
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool LockoutEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public string AccountHolderName { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string DistrictId { get; set; }
        public string DistrictDescription { get; set; }
        public string SubCountyId { get; set; }
        public string SubcountyDescription { get; set; }
        public string NormalizedRoleName { get; set; }
        public int? ContactId { get; set; }
        public int? ServiceProviderId { get; set; }
        public string ServiceProviderDesc { get; set; }
    }
}
