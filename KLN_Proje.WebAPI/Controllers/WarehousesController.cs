using KLN_Proje.Business.Abstract;
using KLN_Proje.Business.Concrete;
using KLN_Proje.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLN_Proje.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehousesController : ControllerBase
    {
        private IWarehouseService _warehouseService;
        public WarehousesController()
        {
            _warehouseService = new WarehouseManager();
        }

        [HttpGet]
        public List<Warehouse> Get()
        {
            return _warehouseService.GetAllWarehouses();
        }

        [HttpGet("{companyId}")]
        public List<Warehouse> Get(int companyId)
        {
            return _warehouseService.GetAllWarehousesById(companyId);
        }

        [HttpPost]
        public Warehouse Create([FromBody] Warehouse warehouse)
        {
            return _warehouseService.CreateWarehouse(warehouse);
        }

        [HttpPut]
        public Warehouse Update([FromBody] Warehouse warehouse)
        {
            return _warehouseService.UpdateWarehouse(warehouse);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _warehouseService.DeleteWarehouse(id);
        }
    }
}
