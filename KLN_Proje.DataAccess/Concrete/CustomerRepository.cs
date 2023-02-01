using KLN_Proje.DataAccess.Abstract;
using KLN_Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLN_Proje.DataAccess.Concrete
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer CreateCustomer(Customer customer)
        {
            using(var _context = new ProjectDbContext())
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
                return customer;
            }
        }

        public void DeleteCustomer(int id)
        {
            using(var _context = new ProjectDbContext())
            {
                var deletedCustomer = _context.Customers.Where(x => x.Id == id).FirstOrDefault();
                _context.Customers.Remove(deletedCustomer);
                _context.SaveChanges();
            }
        }

        public List<Customer> GetAllCustomers()
        {
            using(var _context = new ProjectDbContext())
            {
                return _context.Customers.ToList();
            }
        }

        public Customer UpdateCustomer(Customer customer)
        {
            using(var _context = new ProjectDbContext())
            {
                _context.Customers.Update(customer);
                _context.SaveChanges();
                return customer;
            }
        }
    }
}
