using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheet.Data.Infrastructure;
using TimeSheet.Data.Repositories;
using TimeSheet.Model;

namespace TimeSheet.Service
{
    public interface IProjectTaskService
    {
        IEnumerable<ProjectTask> GetProjectTasks();
        ProjectTask GetProjectTask(int id);
        void CreateProjectTask(ProjectTask projectTask);
        void SaveProjectTask();
    }

    public class ProjectTaskService : IProjectTaskService
    {
        private readonly IProjectTaskRepository projectTaskRepository;
        private readonly IUnitOfWork unitOfWork;

        public ProjectTaskService(IProjectTaskRepository projectTaskRepository, IUnitOfWork unitOfWork)
        {
            this.projectTaskRepository = projectTaskRepository;
            this.unitOfWork = unitOfWork;
        }

        #region Implementation
        public IEnumerable<ProjectTask> GetProjectTasks()
        {
            var projectTasks = projectTaskRepository.GetAll();
            return projectTasks;
        }

        public ProjectTask GetProjectTask(int id)
        {
            var projectTask = projectTaskRepository.GetById(id);
            return projectTask;
        }

        public void CreateProjectTask(ProjectTask projectTask)
        {
            projectTaskRepository.Add(projectTask);
        }

        public void SaveProjectTask()
        {
            unitOfWork.Commit();
        }
        #endregion
    }
}
