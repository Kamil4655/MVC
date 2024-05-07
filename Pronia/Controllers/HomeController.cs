using Microsoft.AspNetCore.Mvc;

namespace Pronia.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> Contanct()
        {
            return View();
        }
        public async Task<IActionResult> Shop()
        {
            return View();
        }
        public async Task<IActionResult> About()
        {
            return View();
        }
    }
}