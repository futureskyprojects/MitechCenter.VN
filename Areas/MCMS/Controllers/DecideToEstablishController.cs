
using Microsoft.AspNetCore.Mvc;
using MitechCenter.vn.Models.Repository;
using MitechCenter.vn.Models;
using MitechCenter.vn.statics;
using Microsoft.AspNetCore.Authorization;

namespace MitechCenter.vn.Areas.MCMS.Controllers
{
    [Area("MCMS")]
    [Authorize(Roles = "0")]
    public class DecideToEstablishController : Controller
    {
        private readonly IDataRepository<StaticElement> _context;
        public DecideToEstablishController(IDataRepository<StaticElement> context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            StaticElement staticElement = _context.Get(StaticElementKey.DECIDE_TO_ESTABLISH);
            return View();
        }
    }
}