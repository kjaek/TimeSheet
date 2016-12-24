using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TimeSheet.Web.Models
{
    public class CustomerViewModel
    {
        public int CustomerID { get; set; }

        [DisplayName("Customer Code:")]
        public string Code { get; set; }

        [DisplayName("Name:")]
        public string Name { get; set; }
        
        [DisplayName("Notes:")]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }


        // TODO: what is reference
        public string Reference { get; set; }
        // TODO: status drop down
        public string Status { get; set; }
    }
}