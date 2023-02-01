using KLN_Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLN_Proje.DataAccess.Abstract
{
    public interface IInvoiceMasterRepository
    {
        public List<InvoiceMaster> GetAllInvoiceMasters();
        public InvoiceMaster GetInvoiceMasterById(int id);
    }
}
