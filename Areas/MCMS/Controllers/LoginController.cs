
using Microsoft.AspNetCore.Mvc;
namespace MitechCenter.vn.Areas.MCMS.Controllers
{
    [Area("MCMS")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}