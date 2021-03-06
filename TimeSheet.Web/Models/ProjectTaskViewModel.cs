﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace TimeSheet.Web.Models
{
    public class ProjectTaskViewModel
    {
        public ProjectTaskViewModel()
        {
            Chargeable = false;
            ChargeableList = new List<SelectListItem>()
            {
                new SelectListItem { Value = "true", Text = "Yes" },
                new SelectListItem { Value = "false", Text = "No" }
            };
        }
        public int ProjectID { get; set; }
        [Required]
        [DisplayName("Description:")]
        [MinLength(2, ErrorMessage = "The {0} must be at least {1} characters long")]
        [MaxLength(50, ErrorMessage = "The {0} must be maximum {1} characters long")]
        public string Description { get; set; }
        [DisplayName("Budget Amount:")]
        [DataType(DataType.Currency)]
        public decimal BudgetAmount { get; set; }
        [DisplayName("Budget Hours:")]
        [Range(0, 9999999999999999.99, ErrorMessage = "Please enter valid integer number")]
        public decimal BudgetHours { get; set; }
        [Required]
        [DisplayName("Chargeable:")]
        public bool Chargeable { get; set; }
        [DisplayName("Notes:")]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        public List<SelectListItem> ChargeableList { get; set; }

        // TODO: get current project name
        public string Project { get; set; }
        // TODO: external id what is it?
        public string ExternalID { get; set; }
        // TODO: sequence no, what is it?
        public string SequenceNo { get; set; }
        // TODO: resource list, what is it?
        public string ResourceList { get; set; }
        // TODO: Reference, what is it?
        public string Reference { get; set; }
        // TODO: select list, Active and Disabled
        public string Status { get; set; }
    }
}