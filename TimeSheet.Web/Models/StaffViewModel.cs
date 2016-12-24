using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TimeSheet.Web.Models
{
    public class StaffViewModel
    {
        public StaffViewModel()
        {
            InitialPassword = "newpwd";
        }

        [Required]
        [MinLength(2, ErrorMessage = "The {0} must be at least {1} characters long")]
        [MaxLength(20, ErrorMessage ="The {0} must be maximum {1} characters long")]
        [DisplayName("First Name:")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "The {0} must be at least {1} characters long")]
        [MaxLength(20, ErrorMessage = "The {0} must be maximum {1} characters long")]
        [DisplayName("Surname:")]
        public string Surname { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "The {0} must be at least {1} characters long")]
        [MaxLength(20, ErrorMessage = "The {0} must be maximum {1} characters long")]
        [DisplayName("Logon ID:")]
        public string LogonID { get; set; }
        [DisplayName("Initial Password:")]
        public string InitialPassword { get; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [DisplayName("Email Address(es):")]
        public string Email { get; set; }
        // TODO: Admin, Casual, Contractor etc need to retrieve from repository
        public string Type { get; set; }
        // TODO: List of suppliers need to retrieve from repository
        public string SupplierName { get; set; }
        // TODO: Resource filter http://www.timesheets.com.au/support_faqs.asp
        public string ResourceFilter { get; set; }
        // TODO: List of projects from repository
        public string GlobalProjects { get; set; }
        [DisplayName("Default Charge Rate:")]
        [DataType(DataType.Currency)]
        public float? ChargeRate { get; set; }
        [DisplayName("Default Cost Rate:")]
        [DataType(DataType.Currency)]
        public float? CostRate { get; set; }
        // TODO: List of managers with selected manager
        public string Manager { get; set; }
        // TODO: Not sure what the purpose of this is
        public string Reference { get; set; }
        [DisplayName("Notes:")]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
        // TODO: Enum Active / Disabled
        public string Status { get; set; }
    }
}