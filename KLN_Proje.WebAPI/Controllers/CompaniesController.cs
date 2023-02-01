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
    public class CompaniesController : ControllerBase
    {
        private ICompanyService _companyService;
        public CompaniesController()
        {
            _companyService = new CompanyManager();
        }

        [HttpGet]
        public List<Office> GetOffices()
        {
            return _companyService.GetAllOffices();
        }

        [HttpPost]
        public Office Post([FromBody]Office office)
        {
            return _companyService.CreateOffice(office);
        }

        [HttpPut]
        public Office Put([FromBody] Office office)
        {
            return _companyService.UpdateOffice(office);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _companyService.DeleteOffice(id);
        }
    }
}
