using KLN_Proje.Business.Abstract;
using KLN_Proje.DataAccess.Abstract;
using KLN_Proje.DataAccess.Concrete;
using KLN_Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLN_Proje.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerRepository _customerRepository;

        public CustomerManager()
        {
            _customerRepository = new CustomerRepository();
        }

        public Customer CreateCustomer(Customer customer)
        {
            return _customerRepository.CreateCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            _customerRepository.DeleteCustomer(id);
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }

        public Customer UpdateCustomer(Customer customer)
        {
            return _customerRepository.UpdateCustomer(customer);
        }
    }
}
