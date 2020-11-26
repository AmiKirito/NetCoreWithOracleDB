using KIC_Lab_4.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KIC_Lab_4.Interfaces
{
    public interface IWorkerService
    {
        public Task<Worker> GetWorkerById(int workerId);

        public Task<ICollection<Worker>> GetWorkers();
    }
}
