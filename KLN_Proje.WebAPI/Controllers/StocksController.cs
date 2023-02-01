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
    public class StocksController : ControllerBase
    {
        private IStockService _stockService;

        public StocksController()
        {
            _stockService = new StockManager();
        }

        [HttpGet]
        public List<Stock> Get()
        {
            return _stockService.GetAllStocks();
        }

        [HttpPost]
        public Stock Create([FromBody] Stock stock)
        {
            return _stockService.CreateStock(stock);
        }

        [HttpPut]
        public Stock Update([FromBody] Stock stock)
        {
            return _stockService.UpdateStock(stock);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _stockService.DeleteStock(id);
        }
    }
}
