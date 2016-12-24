using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheet.Data.Infrastructure;
using TimeSheet.Model;
using TimeSheet.Data.Repositories;

namespace TimeSheet.Service
{
    public interface IProjectService
    {
        Project GetProject(int id);
        IEnumerable<Project> GetProjects();
        void CreateProject(Project project);
        void SaveProject();
    }

    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository projectRepository;
        private readonly IUnitOfWork unitOfWork;

        public ProjectService(IProjectRepository projectRepository, IUnitOfWork unitOfWork)
        {
            this.projectRepository = projectRepository;
            this.unitOfWork = unitOfWork;
        }

        #region Implementation
        public IEnumerable<Project> GetProjects()
        {
            var projects = projectRepository.GetAll();
            return projects;
        }

        public Project GetProject(int id)
        {
            var project = projectRepository.GetById(id);
            return project;
        }

        public void CreateProject(Project project)
        {
            projectRepository.Add(project);
        }

        public void SaveProject()
        {
            unitOfWork.Commit();
        }
        #endregion  
    }
}
