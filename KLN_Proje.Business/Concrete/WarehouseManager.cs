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
    public class WarehouseManager : IWarehouseService
    {
        private IWarehouseRepository _warehouseRepository;

        public WarehouseManager()
        {
            _warehouseRepository = new WarehouseRepository();
        }
        public Warehouse CreateWarehouse(Warehouse warehouse)
        {
            return _warehouseRepository.CreateWarehouse(warehouse);
        }

        public void DeleteWarehouse(int id)
        {
            _warehouseRepository.DeleteWarehouse(id);
        }

        public List<Warehouse> GetAllWarehouses()
        {
            return _warehouseRepository.GetAllWarehouses();
        }

        public List<Warehouse> GetAllWarehousesById(int companyId)
        {
            return _warehouseRepository.GetAllWarehousesById(companyId);
        }

        public Warehouse UpdateWarehouse(Warehouse warehouse)
        {
            return _warehouseRepository.UpdateWarehouse(warehouse);
        }
    }
}
