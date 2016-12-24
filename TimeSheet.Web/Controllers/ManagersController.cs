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
    public class ManagersController : Controller
    {
        private readonly IManagerService managerService;

        public ManagersController(IManagerService managerService)
        {
            this.managerService = managerService;
        }
        // GET: Manager
        public ActionResult Index()
        {
            IEnumerable<ManagerViewModel> managerViewModels;
            IEnumerable<Manager> managers = managerService.GetManagers().ToList();

            managerViewModels = Mapper.Map<IEnumerable<Manager>, IEnumerable<ManagerViewModel>>(managers);
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}