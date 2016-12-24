using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TimeSheet.Web.Models
{
    public class ManagerViewModel
    {
        [Required]
        [MinLength(2, ErrorMessage = "The {0} must be at least {1} characters long")]
        [MaxLength(20, ErrorMessage = "The {0} must be maximum {1} characters long")]
        [DisplayName("First Name:")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "The {0} must be at least {1} characters long")]
        [MaxLength(20, ErrorMessage = "The {0} must be maximum {1} characters long")]
        [DisplayName("Surname:")]
        public string Surname { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [DisplayName("Email Address(es):")]
        public string Email { get; set; }
        // TODO: Allow Logon As list of staff
        public string AllowLogonAs { get; set; }
        // TODO: authorisation methods drop down
        public string AuthorisationMethod { get; set; }
        // TODO: reference, need to see what it does
        public string Reference { get; set; }
        [DisplayName("Notes:")]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
        // TODO: Enum Active / Disabled
        public string Status { get; set; }
    }
}