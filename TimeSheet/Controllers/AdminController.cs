using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimeSheet.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult ProjectTasks()
        {
            return View();
        }

        public ActionResult Customers()
        {
            return View();
        }

        public ActionResult Managers()
        {
            return View();
        }

        public ActionResult Suppliers()
        {
            return View();
        }

        public ActionResult CostCodes()
        {
            return View();
        }
    }
}