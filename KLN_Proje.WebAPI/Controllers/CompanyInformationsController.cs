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
    public class CompanyInformationsController : ControllerBase
    {
        ICompanyInformationService _companyInformationService;
        public CompanyInformationsController()
        {
            _companyInformationService = new CompanyInformationManager();
        }

        [HttpGet]
        public List<Company> GetCompanyInformations()
        {
            return _companyInformationService.GetAllCompanies();
        }
    }
}
