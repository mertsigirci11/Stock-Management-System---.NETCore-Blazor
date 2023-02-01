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
    public class InvoiceDetailsController : ControllerBase
    {
        private IInvoiceDetailService invoiceDetailService;
        public InvoiceDetailsController()
        {
            invoiceDetailService = new InvoiceDetailManager(); 
        }

        [HttpGet("{invoiceMastersId}")]
        public List<InvoiceDetail> GetInvoiceDetails(int invoiceMastersId)
        {
            return invoiceDetailService.GetInvoiceDetails(invoiceMastersId);
        }

    }
}
