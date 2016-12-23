using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeSheet.Models;

namespace TimeSheet.Controllers
{
    public class ProjectTasksController : Controller
    {
        // GET: ProjectTasks
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View(new ProjectTaskViewModel());
        }
    }
}