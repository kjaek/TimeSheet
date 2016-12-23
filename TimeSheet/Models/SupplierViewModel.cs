﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TimeSheet.Models
{
    public class SupplierViewModel
    {
        [DisplayName("Supplier Code:")]
        [Required]
        public string SupplierCode { get; set; }
        [Required]
        [DisplayName("Name:")]
        public string Name { get; set; }
        // TODO: reference check what this does
        public string Reference { get; set; }
        // TODO: drop down list of status
        public string Status { get; set; }
        [DisplayName("Notes:")]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
}