using KLN_Proje.DataAccess.Abstract;
using KLN_Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLN_Proje.DataAccess.Concrete
{
    public class WarehouseRepository : IWarehouseRepository
    {
        public Warehouse CreateWarehouse(Warehouse warehouse)
        {
            using (var _context = new ProjectDbContext())
            {
                _context.Warehouses.Add(warehouse);
                _context.SaveChanges();
                return warehouse;
            }
        }

        public void DeleteWarehouse(int id)
        {
            using (var _context = new ProjectDbContext())
            {
                var deletedWarehouse = _context.Warehouses.Where(i => i.Id == id).FirstOrDefault();
                _context.Warehouses.Remove(deletedWarehouse);
                _context.SaveChanges();
            }
        }

        public List<Warehouse> GetAllWarehouses()
        {
            using (var _context = new ProjectDbContext())
            {
                return _context.Warehouses.ToList();
            }
        }

        public List<Warehouse> GetAllWarehousesById(int companyId)
        {
            using (var _context = new ProjectDbContext())
            {
                return _context.Warehouses.Where(i => i.CompanyId == companyId).ToList();
            }
        }

        public Warehouse UpdateWarehouse(Warehouse warehouse)
        {
            using (var _context = new ProjectDbContext())
            {
                _context.Warehouses.Update(warehouse);
                _context.SaveChanges();
                return warehouse;
            }
        }

    }
}
