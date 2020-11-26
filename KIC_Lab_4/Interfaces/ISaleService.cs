using KIC_Lab_4.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KIC_Lab_4.Interfaces
{
    public interface ISaleService
    {
        public Task<Sale> GetSaleById(int saleId);

        public Task<ICollection<Sale>> GetSales();
    }
}
