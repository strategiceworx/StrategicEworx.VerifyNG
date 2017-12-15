using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StrategicEworx.VerifyNG.Models
{
    public class UserRetiredWorker
    {
        public int id { get; set; }
        public ICollection<User> UserId { get; set; }
        public string VerifiedAge { get; set; }
        public string VerifiedWorkStartDate { get; set; }
        public string VerifiedWorkEndDate { get; set; }
        

    }

    public class UserQualification
    {
    }

    public class UserExamination
    {
    }

    public class UserEducation
    {
        public int id { get; set; }
        public DateTime YearStarted { get; set; }
        public DateTime YearCompleted { get; set; }
        public string Institution { get; set; }
        public string Qualification { get; set; }
        public ICollection<User> UserId { get; set; }
        public string DegreeTitle { get; set; }
    }

    public class User
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [DataType(DataType.Text)]
        public String Title { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Middle Name is required.")]
        [DataType(DataType.Text)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Email Address")]
        [Compare("Email", ErrorMessage = "The email and confirmation email do not match.")]
        public string ConfirmEmail { get; set; }

        [Required(ErrorMessage = "Phone Number is required.")]
        [Phone]
        [StringLength(15, ErrorMessage = "The {0} must be at least {2} characters long", MinimumLength = 11)]
        [Display(Name = "Phone Number")]
        public string TelephoneNumber { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Confirm Date of Birth")]
        [Compare("DateOfBirth", ErrorMessage = "The date of birth and confirmation date of birth do not match.")]
        public DateTime ConfirmDateOfBirth { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        [DataType(DataType.Text)]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Nationality is required.")]
        [DataType(DataType.Text)]
        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        [Required(ErrorMessage = "Local Government Area is required.")]
        [DataType(DataType.Text)]
        [Display(Name = "LGA")]
        public string LGA { get; set; }

        [Required(ErrorMessage = "Mother's maiden name is required.")]
        [DataType(DataType.Text)]
        [Display(Name = "LGA")]
        public string MMaidenName { get; set; }

        [Required(ErrorMessage = "Marital status is required.")]
        [DataType(DataType.Text)]
        [Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [DataType(DataType.Text)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "BVN is required.")]
        [DataType(DataType.Text)]
        [Display(Name = "BVN")]
        public string bankVerificationNumber { get; set; }
   }

    public class BankAccount
    {
        public int id { get; set; }
        public ICollection<User> UserId { get; set; }
        public string BankName { get; set; }
        public int NubanNumber { get; set; }
        public bool BVNLinked { get; set; }
    }

    public class BVN
    {
    }

    public class UserActiveWorker
    {
        public int id { get; set; }
        public ICollection<User> UserId { get; set; }
        public string VerifiedAge { get; set; }
        public string VerifiedWorkStartDate { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        //public ICollection<SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }
    public class LoginViewModel
    {
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [Display(Name = "Telephone Number")]
        [Phone]
        public string TelephoneNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [Display(Name = "Email Address")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Email Address")]
        [Compare("Email", ErrorMessage = "The email and confirmation email do not match.")]
        public string ConfirmEmail { get; set; }

        [Required]
        [Phone]
        [StringLength(15, ErrorMessage = "The {0} must be at least {2} characters long", MinimumLength = 11)]
        [Display(Name = "Phone Number")]
        public string TelephoneNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime Password { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Confirm Date of Birth")]
        [Compare("Password", ErrorMessage = "The date of birth and confirmation date of birth do not match.")]
        public DateTime ConfirmPassword { get; set; }

    }
}