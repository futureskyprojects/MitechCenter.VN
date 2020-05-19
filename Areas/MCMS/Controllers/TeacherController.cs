
using Microsoft.AspNetCore.Mvc;
using MitechCenter.vn.Models.Repository;
using MitechCenter.vn.Models;
using MitechCenter.vn.statics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.IO;
using MitechCenter.vn.Areas.MCMS.Models;
using System;
using Microsoft.AspNetCore.Authorization;

namespace MitechCenter.vn.Areas.MCMS.Controllers
{
    [Area("MCMS")]
    [Authorize(Roles = "0,2")]
    public class TeacherController : Controller
    {
        private readonly IDataRepository<Teacher> _context;
        public TeacherController(IDataRepository<Teacher> context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View(_context.GetAll());
        }
        public IActionResult Create()
        {
            if (TempData["ERROR_NOTIFY"] != null)
            {
                ViewBag.notification = TempData["ERROR_NOTIFY"];
            }
            return View();
        }
        public IActionResult Update(long id)
        {
            if (TempData["ERROR_NOTIFY"] != null)
            {
                ViewBag.notification = TempData["ERROR_NOTIFY"];
            }
            return View(_context.Get(id));
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile avatar, Teacher teacher)
        {
            try
            {
                if (ModelState.IsValid && teacher != null && teacher.tDisplayName != null)
                {
                    if (avatar.Length > 0)
                    {
                        string newPath = "/landing/img/teacher_avatar_" + Stopwatch.GetTimestamp() + ".png";
                        using (var fs = new FileStream("./wwwroot/" + newPath, FileMode.Create))
                        {
                            await avatar.CopyToAsync(fs);
                            teacher.tAvatar = newPath;
                            if (teacher != null && teacher.tId > 0)
                            {
                                _context.Update(_context.Get(teacher.tId), teacher);
                            }
                            else
                            {
                                _context.Add(teacher);
                            }
                        }
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    TempData["ERROR_NOTIFY"] = Notification.Error("LỖI", "Dường như chưa nhập tên cho giảng viên này");
                }
            }
            catch (Exception)
            {
                if (teacher != null && teacher.tId > 0)
                {
                    _context.Update(_context.Get(teacher.tId), teacher);
                    return RedirectToAction("Index");
                }
                TempData["ERROR_NOTIFY"] = Notification.Error("LỖI", "Chưa chọn ảnh cho giảng viên này");
            }
            if (teacher != null && teacher.tId > 0)
            {
                return RedirectToAction("Update", new { id = teacher.tId });
            }
            else
            {
                return RedirectToAction("Create");
            }
        }

        [HttpGet]
        public IActionResult Delete(long id)
        {
            ViewBag.notification = "";
            var teacher = _context.Get(id);
            return View(teacher);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _context.Delete(teacher);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.notification = Notification.Error("LỖI", "Dữ liệu nhập vào không hợp lệ");
            return View();
        }
    }
}