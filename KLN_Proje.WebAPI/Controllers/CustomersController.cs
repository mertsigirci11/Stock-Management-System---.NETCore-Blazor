using KLN_Proje.Business.Abstract;
using KLN_Proje.Business.Concrete;
using KLN_Proje.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLN_Proje.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private ICustomerService _customerService;
        public CustomersController()
        {
            _customerService = new CustomerManager();
        }

        [HttpGet]
        public List<Customer> Get()
        {
            return _customerService.GetAllCustomers();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _customerService.DeleteCustomer(id);
        }

        [HttpPost]
        public Customer Create([FromBody]Customer customer)
        {
            return _customerService.CreateCustomer(customer);
        }

        [HttpPut]
        public Customer  Update([FromBody] Customer customer)
        {
            return _customerService.UpdateCustomer(customer);
        }
    }
}
