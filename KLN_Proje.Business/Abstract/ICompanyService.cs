using KLN_Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLN_Proje.Business.Abstract
{
    public interface ICompanyService
    {
        public List<Office> GetAllOffices();

        public Office CreateOffice(Office office);

        public Office UpdateOffice(Office office);

        public void DeleteOffice(int id);
    }
}
