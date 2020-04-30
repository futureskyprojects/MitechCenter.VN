
using Microsoft.AspNetCore.Mvc;
using MitechCenter.vn.Models.Repository;
using MitechCenter.vn.Models;
using MitechCenter.vn.statics;
namespace MitechCenter.vn.Areas.MCMS.Controllers
{
    [Area("MCMS")]
    public class DevelopmentMottoController : Controller
    {
        private readonly IDataRepository<StaticElement> _context;
        public DevelopmentMottoController(IDataRepository<StaticElement> context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            StaticElement staticElement = _context.Get(StaticElementKey.DEVELOPMENT_MOTTO);
            return View();
        }
    }
}