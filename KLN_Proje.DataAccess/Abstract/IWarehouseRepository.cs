using KLN_Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLN_Proje.DataAccess.Abstract
{
    public interface IWarehouseRepository
    {
        public List<Warehouse> GetAllWarehouses();
        public List<Warehouse> GetAllWarehousesById(int companyId);
        public Warehouse CreateWarehouse(Warehouse warehouse);
        Warehouse UpdateWarehouse(Warehouse warehouse);
        public void DeleteWarehouse(int id);
    }
}
