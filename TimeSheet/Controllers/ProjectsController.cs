using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeSheet.Models;

namespace TimeSheet.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View(new ProjectViewModelcs());
        }
    }
}