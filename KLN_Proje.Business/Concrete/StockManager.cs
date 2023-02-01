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
    public class StockManager : IStockService
    {
        private IStockRepository _stockRepository;

        public StockManager()
        {
            _stockRepository = new StockRepository();
        }
        public Stock CreateStock(Stock stock)
        {
            return _stockRepository.CreateStock(stock);
        }

        public void DeleteStock(int id)
        {
            _stockRepository.DeleteStock(id);
        }

        public List<Stock> GetAllStocks()
        {
            return _stockRepository.GetAllStocks();
        }

        public Stock UpdateStock(Stock stock)
        {
            return _stockRepository.UpdateStock(stock);
        }
    }
}
