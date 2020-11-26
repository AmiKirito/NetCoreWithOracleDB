using KIC_Lab_4.Interfaces;
using KIC_Lab_4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KIC_Lab_4.Controllers
{
    public class GoodController : Controller
    {
        private readonly IGoodService _goodService;

        public GoodController(IGoodService goodService)
        {
            _goodService = goodService;
        }

        [Route("goods/{goodId}")]
        public async Task<IActionResult> GetGoodById(int goodId)
        {
            var good = await _goodService.GetGoodById(goodId);

            return View(good);
        }

        [Route("goods")]
        public async Task<IActionResult> GetGoods()
        {
            var goods = await _goodService.GetGoods();

            return View(goods);
        }

        [HttpGet]
        public IActionResult SetDescription()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SetDescription(GoodDescModel model)
        {
            if (!await _goodService.CheckIfExists(model.Good_Id))
            {
                ModelState.AddModelError("", "Good with such ID does not exist");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _goodService.SetDescription(model);

            var newModel = new
            {
                goodId = model.Good_Id,
            };

            return RedirectToAction("GetGoodById", "Good", newModel);
        }
    }
}
