
using Microsoft.AspNetCore.Mvc;
namespace SampleMVCApps.Controllers
{
    [Route("[controller]")]
    public class MCMSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}