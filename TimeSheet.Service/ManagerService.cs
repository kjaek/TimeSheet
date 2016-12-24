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
    public interface IManagerService
    {
        Manager GetManager(int id);
        IEnumerable<Manager> GetManagers();
        void CreateManager(Manager manager);
        void SaveManager();
    }

    public class ManagerService : IManagerService
    {
        private readonly IManagerRepository managerRepository;
        private readonly IUnitOfWork unitOfWork;

        public ManagerService(IManagerRepository managerRepository, IUnitOfWork unitOfWork)
        {
            this.managerRepository = managerRepository;
            this.unitOfWork = unitOfWork;
        }

        #region Implementation
        public Manager GetManager(int id)
        {
            var manager = managerRepository.GetById(id);
            return manager;
        }

        public IEnumerable<Manager> GetManagers()
        {
            var managers = managerRepository.GetAll();
            return managers;
        }

        public void CreateManager(Manager manager)
        {
            managerRepository.Add(manager);
        }

        public void SaveManager()
        {
            unitOfWork.Commit();
        }
        #endregion
    }
}
