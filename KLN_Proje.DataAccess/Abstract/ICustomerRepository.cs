using KLN_Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLN_Proje.DataAccess.Abstract
{
    public interface ICustomerRepository
    {
        public List<Customer> GetAllCustomers();
        public void DeleteCustomer(int id);
        public Customer UpdateCustomer(Customer customer);
        public Customer CreateCustomer(Customer customer);
    }
}
