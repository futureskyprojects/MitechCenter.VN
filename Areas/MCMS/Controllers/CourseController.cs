
using Microsoft.AspNetCore.Mvc;
using MitechCenter.vn.Models.Repository;
using MitechCenter.vn.Models;
using MitechCenter.vn.statics;
namespace MitechCenter.vn.Areas.MCMS.Controllers
{
    [Area("MCMS")]
    public class CourseController : Controller
    {
        private readonly IDataRepository<Course> _context;
        public CourseController(IDataRepository<Course> context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}