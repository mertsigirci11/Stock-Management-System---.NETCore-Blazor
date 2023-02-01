using KLN_Proje.DataAccess.Abstract;
using KLN_Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLN_Proje.DataAccess.Concrete
{
    public class CompanyRepository : ICompanyRepository
    {
        public Office CreateOffice(Office office)
        {
            using (var _context = new ProjectDbContext())
            {
                _context.Offices.Add(office);
                _context.SaveChanges();
                return office;
            }
        }

        public void DeleteOffice(int id)
        {
            using (var _context = new ProjectDbContext())
            {
                var deletedOffice = _context.Offices.Where(i => i.Id == id).FirstOrDefault();
                _context.Offices.Remove(deletedOffice);
                _context.SaveChanges();
            }
        }

        public List<Office> GetAllOffices()
        {
            using (var _context = new ProjectDbContext())
            {
                return _context.Offices.ToList();
            }
        }

        public Office UpdateOffice(Office office)
        {
            using (var _context = new ProjectDbContext())
            {
                _context.Offices.Update(office);
                _context.SaveChanges();
                return office;
            }
        }

        public List<InvoiceMaster> GetAllInvoiceMasters(Office office)
        {
            using(var _context = new ProjectDbContext())
            {
                var invoiceMasters = _context.InvoiceMasters.Where(i => i.OfficeId == office.Id).ToList();
                return invoiceMasters;
            }
        }

        public List<InvoiceDetail> GetInvoiceDetail(int id)//parameter must be InvoiceMaster's ID.
        {
            using(var _context = new ProjectDbContext())
            {
                var invoiceDetail = _context.InvoiceDetails.Where(i => i.InvoiceMasterId == id).ToList();
                return invoiceDetail;
            }
        }

    }
}
