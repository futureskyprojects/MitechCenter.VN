
using Microsoft.AspNetCore.Mvc;
using MitechCenter.vn.Models.Repository;
using MitechCenter.vn.Models;
using MitechCenter.vn.statics;
using System;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace MitechCenter.vn.Areas.MCMS.Controllers
{
    [Area("MCMS")]
    [Authorize(Roles = "0")]
    public class LogoController : Controller
    {
        private readonly IDataRepository<StaticElement> _context;
        public LogoController(IDataRepository<StaticElement> context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            ViewBag.notification = "";
            StaticElement staticElement = _context.Get(StaticElementKey.LOGO);
            return View(staticElement);
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile logo)
        {
            if (logo.Length > 0)
            {
                string newPath = "/landing/img/logo_" + Stopwatch.GetTimestamp() + ".png";
                using (var fs = new FileStream("./wwwroot/" + newPath, FileMode.Create))
                {
                    await logo.CopyToAsync(fs);
                    StaticElement staticElement = _context.Get(StaticElementKey.LOGO);
                    StaticElement _temp = new StaticElement();
                    _temp.DeepCopy(staticElement);
                    _temp.eData = newPath;
                    _context.Update(staticElement, _temp);
                }
            }
            return RedirectToAction("Index");
        }
    }
}