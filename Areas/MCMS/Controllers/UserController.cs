using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MitechCenter.vn.Areas.MCMS.Models;
using MitechCenter.vn.Models;
using MitechCenter.vn.Models.Repository;

namespace MitechCenter.vn.Areas.MCMS.Controllers
{
    [Area("MCMS")]
    [Authorize(Roles = "0")]
    public class UserController : Controller
    {
        private readonly IDataRepository<User> _context;
        public UserController(IDataRepository<User> context)
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
            return View(new User());
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
        public async Task<IActionResult> Upload(IFormFile avatar, User user)
        {
            try
            {
                if (ModelState.IsValid && user != null)
                {
                    if (avatar.Length > 0)
                    {
                        string newPath = "/landing/img/user_avatar_" + Stopwatch.GetTimestamp() + ".png";
                        using (var fs = new FileStream("./wwwroot/" + newPath, FileMode.Create))
                        {
                            await avatar.CopyToAsync(fs);
                            user.avatar = newPath;
                            if (user != null && user.uId > 0)
                            {
                                if (user.encryptPassword.Length < 8)
                                    throw new Exception("Mật khẩu tối thiểu là 8 ký tự");
                                _context.Update(_context.Get(user.uId), user);
                            }
                            else
                            {
                                _context.Add(user);
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
            catch (Exception e)
            {
                TempData["ERROR_NOTIFY"] = Notification.Error("LỖI", "Chưa chọn ảnh cho giảng viên này");
                System.Console.WriteLine(e.Message);
                if (user != null && user.uId > 0)
                {
                    if (user.encryptPassword.Length < 8)
                    {
                        TempData["ERROR_NOTIFY"] = Notification.Error("LỖI", "Mật khẩu tối thiểu phải đạt 8 ký tự");
                    } else
                    {
                        TempData["ERROR_NOTIFY"] = "";
                        _context.Update(_context.Get(user.uId), user);
                        return RedirectToAction("Index");
                    }
                }
            }
            if (user != null && user.uId >= 0)
            {
                return RedirectToAction("Update", new { id = user.uId });
            }
            else
            {
                return RedirectToAction("Create");
            }
        }




        public IActionResult Delete(long id)
        {
            ViewBag.notification = "";
            var user = _context.Get(id);
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Delete(user);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.notification = Notification.Error("LỖI", "Dữ liệu nhập vào không hợp lệ");
            return View();
        }
    }
}