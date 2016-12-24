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
    public class ProjectTasksController : Controller
    {
        private readonly IProjectTaskService projectTaskService;

        public ProjectTasksController(IProjectTaskService projectTaskService)
        {
            this.projectTaskService = projectTaskService;
        }

        // GET: ProjectTasks
        public ActionResult Index()
        {
            IEnumerable<ProjectTaskViewModel> projectTaskViewModels;
            IEnumerable<ProjectTask> projectTasks;

            projectTasks = projectTaskService.GetProjectTasks().ToList();

            projectTaskViewModels = Mapper.Map<IEnumerable<ProjectTask>, IEnumerable<ProjectTaskViewModel>>(projectTasks);
            return View();
        }

        public ActionResult Edit()
        {
            return View(new ProjectTaskViewModel());
        }
    }
}