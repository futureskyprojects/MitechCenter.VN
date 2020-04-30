
using Microsoft.AspNetCore.Mvc;
using MitechCenter.vn.Models.Repository;
using MitechCenter.vn.Models;
using MitechCenter.vn.statics;
namespace MitechCenter.vn.Areas.MCMS.Controllers
{
    [Area("MCMS")]
    public class ServicesController : Controller
    {
        private readonly IDataRepository<AboutUs> _context;
        public ServicesController(IDataRepository<AboutUs> context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}