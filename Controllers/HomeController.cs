using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MitechCenter.vn.Models;
using MitechCenter.vn.Models.DataManager;
using MitechCenter.vn.Models.Repository;

namespace MitechCenter.vn.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataRepository<News> _context;
        private readonly IDataRepository<NewsCategory> _context_temp;
        public HomeController(IDataRepository<News> context, IDataRepository<NewsCategory> context_temp)
        {
            this._context = context;
            this._context_temp = context_temp;
        }
        public IActionResult Index()
        {
            var news = ((NewsManager)_context).GetSize(3);
            ViewBag.ncs = _context_temp.GetAll();
            ViewBag.partners = Partners.fetchAll();
            return View(news);
        }
    }
}
