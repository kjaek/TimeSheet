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
    public interface ICustomerService
    {
        Customer GetCustomer(int id);
        IEnumerable<Customer> GetCustomers();
        void CreateCustomer(Customer customer);
        void SaveCustomer();
    }

    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;

        public CustomerService(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
        {
            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }

        #region Implementation
        public Customer GetCustomer(int id)
        {
            var customer = customerRepository.GetById(id);
            return customer;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            var customers = customerRepository.GetAll();
            return customers;
        }

        public void CreateCustomer(Customer customer)
        {
            customerRepository.Add(customer);
        }

        public void SaveCustomer()
        {
            unitOfWork.Commit();
        }
        #endregion
    }
}
