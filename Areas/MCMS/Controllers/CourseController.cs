
using Microsoft.AspNetCore.Mvc;
using MitechCenter.vn.Models.Repository;
using MitechCenter.vn.Models;
using MitechCenter.vn.statics;
using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using MitechCenter.vn.Areas.MCMS.Models;

namespace MitechCenter.vn.Areas.MCMS.Controllers
{
    [Area("MCMS")]
    public class CourseController : Controller
    {
        private readonly IDataRepository<Course> _context;
        private readonly IDataRepository<Teacher> _teacher;
        public CourseController(IDataRepository<Course> context, IDataRepository<Teacher> teacher)
        {
            this._context = context;
            this._teacher = teacher;
        }
        public IActionResult Index()
        {
            ViewBag.teachers = _teacher.GetAll();
            return View(_context.GetAll());
        }
        public IActionResult Create(long id, Course course = null)
        {
            var t = _teacher.Get(id);
            if (t == null)
            {
                throw new Exception("Không có giáo viên này");
            }
            else
            {
                ViewBag.teacher = t;
                if (course == null)
                    course = new Course();
                course.tId = (int)id;
                return View(course);
            }
        }

        [HttpPost]
        public IActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                if (course.cName.Length <= 0 || course.cDescription.Length <= 0 || course.cDetail.Length <= 0 || course.cImage.Length <= 0 || course.cLearningTime.Length <= 0 || course.cSchedule.Length <= 0)
                {
                    ViewBag.notification = Notification.Error("LỖI", "Vui lòng nhập đầy đủ dữ liệu");
                    return RedirectToAction("Create", new { id = course.tId, course = course });
                }
                else
                {
                    _context.Add(course);
                }
            }
            else
            {
                ViewBag.notification = Notification.Error("LỖI", "Dữ liệu nhập vào không hợp lệ");
                return RedirectToAction("Create", new { id = course.tId, course = course });
            }
            return RedirectToAction("Index");
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

        public IActionResult Update(long? id, Course course = null)
        {
            if (id != null)
            {
                course = _context.Get((int)id);
            }
            var t = _teacher.Get(course.tId);
            if (t == null)
            {
                throw new Exception("Không có giáo viên này");
            }
            else
            {
                ViewBag.teacher = t;
                return View(course);
            }
        }

        [HttpPost, ActionName("Update")]
        public IActionResult UpdateNow(Course course)
        {
            if (ModelState.IsValid)
            {
                if (course.cName.Length <= 0 || course.cDescription.Length <= 0 || course.cDetail.Length <= 0 || course.cImage.Length <= 0 || course.cLearningTime.Length <= 0 || course.cSchedule.Length <= 0)
                {
                    ViewBag.notification = Notification.Error("LỖI", "Vui lòng nhập đầy đủ dữ liệu");
                    return RedirectToAction("Create", new { id = course.tId, course = course });
                }
                else
                {
                    _context.Update(_context.Get(course.cId), course);
                }
            }
            else
            {
                ViewBag.notification = Notification.Error("LỖI", "Dữ liệu nhập vào không hợp lệ");
                return RedirectToAction("Update", new { id = course.cId, course = course });
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(long id)
        {
            return View(_context.Get(id));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteNow(long id)
        {
            _context.Delete(_context.Get(id));
            return RedirectToAction("Index");
        }
    }
}