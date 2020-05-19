
using Microsoft.AspNetCore.Mvc;
using MitechCenter.vn.Models.Repository;
using MitechCenter.vn.Models;
using MitechCenter.vn.statics;
using System;
using MitechCenter.vn.Areas.MCMS.Models;
using Microsoft.AspNetCore.Authorization;

namespace MitechCenter.vn.Areas.MCMS.Controllers
{
    [Area("MCMS")]
    [Authorize(Roles = "0,1")]
    public class NewsCategoryController : Controller
    {
        private readonly IDataRepository<NewsCategory> _context;
        public NewsCategoryController(IDataRepository<NewsCategory> context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var newsCategories = _context.GetAll();
            return View(newsCategories);
        }
        public IActionResult Create()
        {
            ViewBag.notification = "";
            return View();
        }

        [HttpPost]
        public IActionResult Create(NewsCategory newsCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newsCategory);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.notification = Notification.Error("LỖI", "Dữ liệu nhập vào không hợp lệ");
            return View();
        }

        [HttpGet]
        public IActionResult Update(long id)
        {
            ViewBag.notification = "";
            var newsCategory = _context.Get(id);
            return View(newsCategory);
        }

        [HttpPost, ActionName("Update")]
        public IActionResult UpdateToNew(NewsCategory newsCategory)
        {
            if (ModelState.IsValid)
            {
                newsCategory.updateAt = DateTime.Now;
                var newsCategoryDb = _context.Get(newsCategory.ncId);
                _context.Update(newsCategoryDb, newsCategory);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.notification = Notification.Error("LỖI", "Dữ liệu nhập vào không hợp lệ");
            return View();
        }

        [HttpGet]
        public IActionResult Delete(long id)
        {
            ViewBag.notification = "";
            var newsCategory = _context.Get(id);
            return View(newsCategory);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(NewsCategory newsCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Delete(newsCategory);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.notification = Notification.Error("LỖI", "Dữ liệu nhập vào không hợp lệ");
            return View();
        }
    }
}