using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeSheet.Web.Models;
using TimeSheet.Service;
using TimeSheet.Model;
using AutoMapper;

namespace TimeSheet.Web.Controllers
{
    public class SuppliersController : Controller
    {
        private readonly ISupplierService supplierService;

        public SuppliersController(ISupplierService supplierService)
        {
            this.supplierService = supplierService;
        }
        // GET: Suppliers
        public ActionResult Index()
        {
            IEnumerable<SupplierViewModel> supplierViewModels;
            IEnumerable<Supplier> suppliers = supplierService.GetSuppliers().ToList();

            supplierViewModels = Mapper.Map<IEnumerable<Supplier>,IEnumerable<SupplierViewModel >> (suppliers);
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}