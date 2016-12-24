using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TimeSheet.Web.Models
{
    public class StaffProjectViewModel
    {
        public StaffProjectViewModel()
        {
            ChargeRate = 0;
            CostRate = 0;
        }

        public int StaffProjectID { get; set; }

        [DisplayName("Role:")]
        [MinLength(2, ErrorMessage = "The {0} must be at least {1} characters long")]
        [MaxLength(10, ErrorMessage = "The {0} must be maximum {1} characters long")]
        public string Role { get; set; }

        [DisplayName("Hourly Charge Rate:")]
        [DataType(DataType.Currency)]
        public decimal ChargeRate { get; set; }

        [DisplayName("Hourly Cost Rate:")]
        [DataType(DataType.Currency)]
        public decimal CostRate { get; set; }


        // TODO: list of projects
        public string Project { get; set; }
        // TODO: list of staff
        public string Staff { get; set; }
        // TODO: drop down list of cost codes
        public string CodeCode { get; set; }
        // TODO: drop down list of status
        public string Status { get; set; }
    }
}