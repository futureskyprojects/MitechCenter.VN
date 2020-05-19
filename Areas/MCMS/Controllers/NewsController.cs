
using Microsoft.AspNetCore.Mvc;
using MitechCenter.vn.Models.Repository;
using MitechCenter.vn.Models;
using MitechCenter.vn.statics;
using MitechCenter.vn.Areas.MCMS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using MitechCenter.vn.Models.DataManager;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.IO;
using System;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace MitechCenter.vn.Areas.MCMS.Controllers
{
    [Area("MCMS")]
    [Authorize(Roles = "0,1")]
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
                news.uId = int.Parse(User.Claims.FirstOrDefault(c => c.Type == "ID").Value);
                // contentProcessing(news.nContent);
                _context.Add(news);
                return RedirectToAction(nameof(Index), new { id = news.ncId.ToString() });
            }
            ViewBag.notification = Notification.Error("LỖI", "Dữ liệu nhập vào không hợp lệ");
            return View();
        }

        [HttpPost]
        public IActionResult ImageUpload(IFormFile upload)
        {
            var filename = DateTime.Now.ToString("yyyyMMddHHmmss_") + upload.FileName;
            var pathFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
            if (!Directory.Exists(pathFile))
            {
                Directory.CreateDirectory(pathFile);
            }
            pathFile = Path.Combine(pathFile, filename);
            Console.WriteLine(pathFile);
            var stream = new FileStream(pathFile, FileMode.CreateNew);
            upload.CopyToAsync(stream);
            return new JsonResult(new { path = "/uploads/" + filename });
        }


        public IActionResult Update(long id)
        {
            ViewBag.notification = "";
            var news = _context.Get(id);
            return View(news);
        }

        [HttpPost, ActionName("Update")]
        public IActionResult UpdateNews(News news)
        {
            if (ModelState.IsValid)
            {
                news.uId = 1;
                var newsDb = _context.Get(news.nId);
                _context.Update(newsDb, news);
                return RedirectToAction(nameof(Index), new { id = news.ncId.ToString() });
            }
            ViewBag.notification = Notification.Error("LỖI", "Dữ liệu nhập vào không hợp lệ");
            return View();
        }

        [HttpGet]
        public IActionResult Delete(long id)
        {
            ViewBag.notification = "";
            var news = _context.Get(id);
            return View(news);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(News news)
        {
            if (ModelState.IsValid)
            {
                _context.Delete(news);
                return RedirectToAction(nameof(Index), new { id = news.ncId.ToString() });
            }
            ViewBag.notification = Notification.Error("LỖI", "Dữ liệu nhập vào không hợp lệ");
            return View();
        }
    }
}