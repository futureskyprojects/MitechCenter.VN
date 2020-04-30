using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MitechCenter.vn.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel();
            return View(homeViewModel);
        }
    }
}
