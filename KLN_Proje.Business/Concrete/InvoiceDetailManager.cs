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
    public class InvoiceDetailManager : IInvoiceDetailService
    {
        private IInvoiceDetailRepository invoiceDetailRepository;
        public InvoiceDetailManager()
        {
            invoiceDetailRepository = new InvoiceDetailRepository();
        }
        
        public List<InvoiceDetail> GetInvoiceDetails(int invoiceMasterId)
        {
            return invoiceDetailRepository.GetInvoiceDetails(invoiceMasterId);
        }
    }
}
