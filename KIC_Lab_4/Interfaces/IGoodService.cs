using KIC_Lab_4.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KIC_Lab_4.Interfaces
{
    public interface IGoodService
    {
        public Task<ICollection<Good>> GetGoods();

        public Task<bool> CheckIfExists(int goodId);

        public Task SetDescription(GoodDescModel model);

        public Task<Good> GetGoodById(int goodId);
    }
}
