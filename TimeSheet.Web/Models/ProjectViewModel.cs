using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace TimeSheet.Web.Models
{
    public class ProjectViewModel
    {
        public ProjectViewModel()
        {
            Chargeable = false;
            BudgetAmount = 0;
            ChargeableList = new List<SelectListItem>()
            {
                new SelectListItem { Value = "true", Text = "Yes" },
                new SelectListItem { Value = "false", Text = "No" }
            };
        }
        
        public int ProjectID { get; set; }
        [Required]
        [DisplayName("Project Code:")]
        [MinLength(2, ErrorMessage = "The {0} must be at least {1} characters long")]
        [MaxLength(10, ErrorMessage = "The {0} must be maximum {1} characters long")]
        public string Code { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "The {0} must be at least {1} characters long")]
        [MaxLength(50, ErrorMessage = "The {0} must be maximum {1} characters long")]
        [DisplayName("Description:")]
        public string Description { get; set; }
        [DisplayName("Budget Amount:")]
        [DataType(DataType.Currency)]
        public decimal BudgetAmount { get; set; }
        [Required]
        [DisplayName("Chargeable:")]
        public bool Chargeable { get; set; }
        [DisplayName("Notes:")]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        public List<SelectListItem> ChargeableList { get; set; }

        // TODO: list of customers (companies)
        public string Customer { get; set; }
        // TODO: global project, automatically assign staff or not
        public string GlobalProject { get; set; }
        // TODO: project types
        public string Type { get; set; }
        // TODO: list of managers
        public string Manager { get; set; }
        // TODO: not sure what this is for
        public string Reference { get; set; }
        // TODO: select list, Active and Disabled
        public string Status { get; set; }
        
    }
}