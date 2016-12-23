using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TimeSheet.Models
{
    public class CustomerViewModel
    {
        [DisplayName("Customer Code:")]
        public string CustomerCode { get; set; }
        [DisplayName("Name:")]
        public string Name { get; set; }
        // TODO: what is reference
        public string Reference { get; set; }
        [DisplayName("Notes:")]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
}