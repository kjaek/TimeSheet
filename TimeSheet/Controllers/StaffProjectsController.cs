using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeSheet.Models;

namespace TimeSheet.Controllers
{
    public class StaffProjectsController : Controller
    {
        // GET: StaffProjects
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View(new StaffProjectViewModel());
        }
    }
}