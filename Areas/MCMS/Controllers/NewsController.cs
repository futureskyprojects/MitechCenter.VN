
using Microsoft.AspNetCore.Mvc;
using MitechCenter.vn.Models.Repository;
using MitechCenter.vn.Models;
using MitechCenter.vn.statics;
namespace MitechCenter.vn.Areas.MCMS.Controllers
{
    [Area("MCMS")]
    public class NewsController : Controller
    {
        private readonly IDataRepository<News> _context;
        public NewsController(IDataRepository<News> context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}