
using System;
using Microsoft.AspNetCore.Mvc;
using MitechCenter.vn.Models;
using MitechCenter.vn.Models.Repository;
using MitechCenter.vn.statics;

namespace MitechCenter.vn.Areas.MCMS.Controllers
{
    [Area("MCMS")]
    public class EducationProgramController : Controller
    {
        private readonly IDataRepository<StaticElement> _context;
        public EducationProgramController(IDataRepository<StaticElement> context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            StaticElement staticElement = _context.Get(StaticElementKey.EDUCATION_PROGRAM);
            return View();
        }
    }
}