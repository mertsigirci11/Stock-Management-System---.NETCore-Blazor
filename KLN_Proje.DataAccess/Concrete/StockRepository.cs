using KLN_Proje.DataAccess.Abstract;
using KLN_Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLN_Proje.DataAccess.Concrete
{
    public class StockRepository : IStockRepository
    {
        public Stock CreateStock(Stock stock)
        {
            using (var _context = new ProjectDbContext())
            {
                _context.Stocks.Add(stock);
                _context.SaveChanges();
                return stock;
            }
        }

        public void DeleteStock(int id)
        {
            using (var _context = new ProjectDbContext())
            {
                //var deletedStock = _context.Stocks.Where(i => i.Id == id).FirstOrDefault();
                var deletedStock = _context.Stocks.Where(i => i.Id == id).ToList();//dene
                _context.Stocks.Remove(deletedStock.First());
                _context.SaveChanges();
            }
        }

        public List<Stock> GetAllStocks()
        {
            using (var _context = new ProjectDbContext())
            {
                return _context.Stocks.ToList();
            }
        }

        public Stock UpdateStock(Stock stock)
        {
            using (var _context = new ProjectDbContext())
            {
                _context.Stocks.Update(stock);
                _context.SaveChanges();
                return stock;
            }
        }
    }
}
