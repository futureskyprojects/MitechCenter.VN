
using Microsoft.AspNetCore.Mvc;
namespace MitechCenter.vn.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}