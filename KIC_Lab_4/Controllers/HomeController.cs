using Microsoft.AspNetCore.Mvc;

namespace KIC_Lab_4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
