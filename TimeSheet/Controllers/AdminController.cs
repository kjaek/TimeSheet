﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimeSheet.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult StaffAdmin()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult StaffProjects()
        {
            return View();
        }
    }
}