using System;
using System.ComponentModel.DataAnnotations;

namespace MUCOBADI.Data
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        //private string _Email;
        public string Email { get; set; }
        //public string Email { get { return this._Email; } set { UserName = value; _Email = value; } }

        [Required]
        [Display(Name = "Contact")]
        public int Contact { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        //[Required]
        //[Display(Name = "Account Holder")]
        //public string StaffId { get; set; }
        [Required]
        [Display(Name = "Account Holder Name")]
        public string AccountHolderName { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "User Role")]
        public string UserRole { get; set; }

        [Display(Name = "District")]
        public int?[] DistrictId { get; set; }

        [Display(Name = "Sub-County")]
        public int?[] SubcountyId { get; set; }

        [Display(Name = "Facility")]
        public int?[] FacilityId { get; set; }
    }
    public class ExternalRegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        private string _Email;
        public string Email { get { return this._Email; } set { UserName = value; _Email = value; } }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        //[Required]
        //[Display(Name = "Account Holder")]
        //public string StaffId { get; set; }
        [Required]
        [Display(Name = "Account Holder Name")]
        public string AccountHolderName { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        //[Required]
        [Display(Name = "User Role")]
        public string UserRole { get; set; }
    }
}
