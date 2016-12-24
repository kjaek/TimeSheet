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
    public class CustomersController : Controller
    {
        private readonly ICustomerService customerService;

        public CustomersController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        // GET: Customers
        public ActionResult Index()
        {
            IEnumerable<CustomerViewModel> customerViewModels;
            IEnumerable<Customer> customers = customerService.GetCustomers().ToList();

            customerViewModels = Mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerViewModel>>(customers);
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}