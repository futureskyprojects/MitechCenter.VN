
using Microsoft.AspNetCore.Mvc;
using MitechCenter.vn.Models.Repository;
using MitechCenter.vn.Models;
using MitechCenter.vn.statics;
namespace MitechCenter.vn.Areas.MCMS.Controllers
{
    [Area("MCMS")]
    public class TeacherController : Controller
    {
        private readonly IDataRepository<Teacher> _context;
        public TeacherController(IDataRepository<Teacher> context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}