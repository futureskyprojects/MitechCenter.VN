
using Microsoft.AspNetCore.Mvc;
using MitechCenter.vn.Models.Repository;
using MitechCenter.vn.Models;
using MitechCenter.vn.statics;
using MitechCenter.vn.Areas.MCMS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using MitechCenter.vn.Models.DataManager;
using System.Collections.Generic;

namespace MitechCenter.vn.Areas.MCMS.Controllers
{
    [Area("MCMS")]
    public class NewsController : Controller
    {
        private readonly IDataRepository<News> _context;
        private readonly IDataRepository<NewsCategory> _context_temp;
        public NewsController(IDataRepository<News> context, IDataRepository<NewsCategory> context_temp)
        {
            this._context = context;
            this._context_temp = context_temp;
        }
        public IActionResult Index(string id)
        {
            IEnumerable<News> news;
            if (id != null)
            {
                NewsManager newsManager = (NewsManager)_context;
                news = newsManager.GetAll(long.Parse(id));
            }
            else
            {
                news = _context.GetAll();
            }
            return View(news);
        }
        public IActionResult Create()
        {
            ViewBag.notification = "";
            ViewBag.newsCategories = new SelectList(_context_temp.GetAll(), "ncId", "ncName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(News news)
        {
            if (ModelState.IsValid)
            {
                news.uId = 1;
                _context.Add(news);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.notification = Notification.Error("LỖI", "Dữ liệu nhập vào không hợp lệ");
            return View();
        }

    }
}