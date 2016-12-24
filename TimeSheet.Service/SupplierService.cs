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
    public interface ISupplierService
    {
        Supplier GetSupplier(int id);
        IEnumerable<Supplier> GetSuppliers();
        void CreateSupplier(Supplier supplier);
        void SaveSupplier();
    }

    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository supplierRepository;
        private readonly IUnitOfWork unitOfWork;

        public SupplierService(ISupplierRepository supplierRepository, IUnitOfWork unitOfWork)
        {
            this.supplierRepository = supplierRepository;
            this.unitOfWork = unitOfWork;
        }

        #region Implementation
        public Supplier GetSupplier(int id)
        {
            var supplier = supplierRepository.GetById(id);
            return supplier;
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
            var suppliers = supplierRepository.GetAll();
            return suppliers;
        }

        public void CreateSupplier(Supplier supplier)
        {
            supplierRepository.Add(supplier);
        }

        public void SaveSupplier()
        {
            unitOfWork.Commit();
        }
        #endregion  
    }
}
