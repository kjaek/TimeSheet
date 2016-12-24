using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TimeSheet.Web.Models
{
    public class CostCodeViewModel
    {
        public CostCodeViewModel()
        {
            Amount = 0;
        }
        [Required]
        [DisplayName("Cost Code:")]
        public string CostCode { get; set; }
        [DisplayName("Comments:")]
        public string Comments { get; set; }
        [Required]
        [DisplayName("Amount:")]
        [DataType(DataType.Currency)]
        public float? Amount { get; set; }
        // TODO: drop down list of status
        public string Status { get; set; }
    }
}