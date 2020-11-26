using System.Threading.Tasks;
using KIC_Lab_4.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KIC_Lab_4.Controllers
{
    public class WorkerController : Controller
    {
        private readonly IWorkerService _workerService;

        public WorkerController(IWorkerService workerService)
        {
            _workerService = workerService;
        }

        public async Task<IActionResult> GetWorkerById(int workerId)
        {
            var worker = await _workerService.GetWorkerById(workerId);

            return View(worker);
        }

        public async Task<IActionResult> GetWorkers()
        {
            var workers = await _workerService.GetWorkers();

            return View(workers);
        }
    }
}
