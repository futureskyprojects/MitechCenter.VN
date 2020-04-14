
using Microsoft.AspNetCore.Mvc;
namespace SampleMVCApps.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}