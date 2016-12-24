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
    public interface IStaffProjectService
    {
        StaffProject GetStaffProject(int id);
        IEnumerable<StaffProject> GetStaffProjects();
        void CreateStaffProject(StaffProject staffProject);
        void SaveStaffProject();
    }

    public class StaffProjectService : IStaffProjectService
    {
        private readonly IStaffProjectRepository staffProjectRepository;
        private readonly IUnitOfWork unitOfWork;

        public StaffProjectService(IStaffProjectRepository staffProjectRepository, IUnitOfWork unitOfWork)
        {
            this.staffProjectRepository = staffProjectRepository;
            this.unitOfWork = unitOfWork;
        }

        #region Implementation
        public StaffProject GetStaffProject(int id)
        {
            var staffProject = staffProjectRepository.GetById(id);
            return staffProject;
        }

        public IEnumerable<StaffProject> GetStaffProjects()
        {
            var staffProjects = staffProjectRepository.GetAll();
            return staffProjects;
        }

        public void CreateStaffProject(StaffProject staffProject)
        {
            staffProjectRepository.Add(staffProject);
        }

        public void SaveStaffProject()
        {
            unitOfWork.Commit();
        }
        #endregion
    }
}
