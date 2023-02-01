using KLN_Proje.DataAccess.Abstract;
using KLN_Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLN_Proje.DataAccess.Concrete
{
    public class CompanyInformationRepository : ICompanyInformationRepository
    {
        public List<Company> GetAllCompanies()
        {
            using(var _context = new ProjectDbContext())
            {
                return _context.Companies.ToList();
            }
        }
    }
}
