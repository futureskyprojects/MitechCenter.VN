
using Microsoft.AspNetCore.Mvc;
using MitechCenter.vn.Models.Repository;
using MitechCenter.vn.Models;
using MitechCenter.vn.statics;
using Microsoft.AspNetCore.Authorization;

namespace MitechCenter.vn.Areas.MCMS.Controllers
{
    [Area("MCMS")]
    [Authorize(Roles = "0")]
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