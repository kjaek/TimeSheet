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
    public class ProjectsController : Controller
    {
        private readonly IProjectService projectService;

        public ProjectsController(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        // GET: Projects
        public ActionResult Index()
        {
            IEnumerable<ProjectViewModel> projectViewModels;
            IEnumerable<Project> projects;

            projects = projectService.GetProjects().ToList();

            projectViewModels = Mapper.Map<IEnumerable<Project>, IEnumerable<ProjectViewModel>>(projects);
            return View();
        }

        public ActionResult Edit()
        {
            return View(new ProjectViewModel());
        }
    }
}