using KLN_Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLN_Proje.Business.Abstract
{
    public interface ICustomerService
    {
        public List<Customer> GetAllCustomers();
        public Customer UpdateCustomer(Customer customer);
        public void DeleteCustomer(int id);
        public Customer CreateCustomer(Customer customer);
    }
}