
using Microsoft.AspNetCore.Mvc;
using MitechCenter.vn.Models.Repository;
using MitechCenter.vn.Models;
using MitechCenter.vn.statics;
namespace MitechCenter.vn.Areas.MCMS.Controllers
{
    [Area("MCMS")]
    public class NewsCategoryController : Controller
    {
        private readonly IDataRepository<NewsCategory> _context;
        public NewsCategoryController(IDataRepository<NewsCategory> context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}