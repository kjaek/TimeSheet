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
    public interface IStaffService
    {
        Staff GetStaff(int id);
        IEnumerable<Staff> GetStaff();
        void CreateStaff(Staff staff);
        void SaveStaff();
    }

    public class StaffService : IStaffService
    {
        private readonly IStaffRepository staffRepository;
        private readonly IUnitOfWork unitOfWork;

        public StaffService(IStaffRepository staffRepository, IUnitOfWork unitOfWork)
        {
            this.staffRepository = staffRepository;
            this.unitOfWork = unitOfWork;
        }

        #region Implementation
        public Staff GetStaff(int id)
        {
            var staff = staffRepository.GetById(id);
            return staff;
        }

        public IEnumerable<Staff> GetStaff()
        {
            var staff = staffRepository.GetAll();
            return staff;
        }

        public void CreateStaff(Staff staff)
        {
            staffRepository.Add(staff);
        }

        public void SaveStaff()
        {
            unitOfWork.Commit();
        }
        #endregion
    }
}
