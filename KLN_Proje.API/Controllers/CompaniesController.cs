using KLN_Proje.Business.Abstract;
using KLN_Proje.Business.Concrete;
using KLN_Proje.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLN_Proje.API.Controllers
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

        [HttpGet]
        public List<Warehouse> GetWarehouses()
        {
            return _companyService.GetAllWarehouses();
        }

        [HttpGet]
        public List<Stock> GetStocks()
        {
            return _companyService.GetALlStocks();
        }
    }
}
