using KLN_Proje.DataAccess.Abstract;
using KLN_Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLN_Proje.DataAccess.Concrete
{
    public class InvoiceMasterRepository : IInvoiceMasterRepository
    {
        public InvoiceMaster GetInvoiceMasterById(int id)
        {
            using(var _contex = new ProjectDbContext())
            {
                return _contex.InvoiceMasters.Where(i => i.Id == id).FirstOrDefault();
            }
        }

        public List<InvoiceMaster> GetAllInvoiceMasters()
        {
            using (var _contex = new ProjectDbContext())
            {
                return _contex.InvoiceMasters.ToList();
            }
        }
    }
}
