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
    public class InvoiceMastersController : ControllerBase
    {
        private IInvoiceMasterService invoiceMasterService;
        public InvoiceMastersController()
        {
            invoiceMasterService = new InvoiceMasterManager();
        }

        [HttpGet]
        public List<InvoiceMaster> GetInvoiceMasters()
        {
            return invoiceMasterService.GetAllInvoiceMasters();
        }

        [HttpGet("{id}")]
        public InvoiceMaster GetInvoiceMasterById(int id)
        {
            return invoiceMasterService.GetInvoiceMasterById(id);
        }
    }
}
