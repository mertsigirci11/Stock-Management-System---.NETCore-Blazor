using KLN_Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLN_Proje.Business.Abstract
{
    public interface IInvoiceDetailService
    {
        public List<InvoiceDetail> GetInvoiceDetails(int invoiceMasterId);
    }
}
