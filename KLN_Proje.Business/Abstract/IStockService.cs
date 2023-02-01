using KLN_Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLN_Proje.Business.Abstract
{
    public interface IStockService
    {
        public List<Stock> GetAllStocks();
        public Stock CreateStock(Stock stock);
        Stock UpdateStock(Stock stock);
        public void DeleteStock(int id);
    }
}
