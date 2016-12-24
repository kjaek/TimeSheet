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
    public class StaffController : Controller
    {
        private readonly IStaffService staffService;

        public StaffController(IStaffService staffService)
        {
            this.staffService = staffService;
        }

        // GET: Staff
        public ActionResult Index()
        {
            IEnumerable<StaffViewModel> staffViewModels;
            IEnumerable<Staff> staff = staffService.GetStaff().ToList();

            staffViewModels = Mapper.Map<IEnumerable<Staff>, IEnumerable<StaffViewModel>>(staff);
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}