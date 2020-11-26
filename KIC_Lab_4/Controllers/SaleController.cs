using System.Threading.Tasks;
using KIC_Lab_4.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KIC_Lab_4.Controllers
{
    public class SaleController : Controller
    {
        private readonly ISaleService _saleService;

        public SaleController(ISaleService saleService)
        {
            _saleService = saleService;
        }

        public async Task<IActionResult> GetSaleById(int saleId)
        {
            var sale = await _saleService.GetSaleById(saleId);

            return View(sale);
        }

        public async Task<IActionResult> GetSales()
        {
            var sales = await _saleService.GetSales();

            return View(sales);
        }
    }
}
