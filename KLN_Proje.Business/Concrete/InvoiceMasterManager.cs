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
    public class InvoiceMasterManager : IInvoiceMasterService
    {
        private IInvoiceMasterRepository invoiceMasterRepository;
        public InvoiceMasterManager()
        {
            invoiceMasterRepository = new InvoiceMasterRepository();
        }

        public List<InvoiceMaster> GetAllInvoiceMasters()
        {
            return invoiceMasterRepository.GetAllInvoiceMasters();
        }

        public InvoiceMaster GetInvoiceMasterById(int id)
        {
            return invoiceMasterRepository.GetInvoiceMasterById(id);
        }
    }
}
