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
    public class StaffProjectsController : Controller
    {
        private readonly IStaffProjectService staffProjectService;

        public StaffProjectsController(IStaffProjectService staffProjectService)
        {
            this.staffProjectService = staffProjectService;
        }

        // GET: StaffProjects
        public ActionResult Index()
        {
            IEnumerable<StaffProjectViewModel> staffProjectViewModels;
            IEnumerable<StaffProject> staffProjects = staffProjectService.GetStaffProjects().ToList();

            staffProjectViewModels = Mapper.Map<IEnumerable<StaffProject>, IEnumerable<StaffProjectViewModel>>(staffProjects);
            return View();
        }

        public ActionResult Edit()
        {
            return View(new StaffProjectViewModel());
        }
    }
}