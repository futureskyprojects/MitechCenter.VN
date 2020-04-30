
using Microsoft.AspNetCore.Mvc;
using MitechCenter.vn.Models.Repository;
using MitechCenter.vn.Models;
using MitechCenter.vn.statics;
namespace MitechCenter.vn.Areas.MCMS.Controllers
{
    [Area("MCMS")]
    public class OrganizationController : Controller
    {
        private readonly IDataRepository<AboutUs> _context;
        public OrganizationController(IDataRepository<AboutUs> context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}