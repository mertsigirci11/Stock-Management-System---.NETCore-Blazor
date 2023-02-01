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
    public class CompanyManager : ICompanyService
    {
        private ICompanyRepository _companyRepository;
        public CompanyManager()
        {
            _companyRepository = new CompanyRepository();
        }

        public Office CreateOffice(Office office)
        {
            return _companyRepository.CreateOffice(office);
        }

        public void DeleteOffice(int id)
        {
            _companyRepository.DeleteOffice(id);
        }

        public List<Office> GetAllOffices()
        {
            return _companyRepository.GetAllOffices();
        }

        public Office UpdateOffice(Office office)
        {
            return _companyRepository.UpdateOffice(office);
        }
    }
}
