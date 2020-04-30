
using Microsoft.AspNetCore.Mvc;
using MitechCenter.vn.Models.Repository;
using MitechCenter.vn.Models;
using MitechCenter.vn.statics;
using System;
using MitechCenter.vn.Areas.MCMS.Models;

namespace MitechCenter.vn.Areas.MCMS.Controllers
{
    [Area("MCMS")]
    public class OwnerController : Controller
    {
        private readonly IDataRepository<StaticElement> _context;
        public OwnerController(IDataRepository<StaticElement> context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            ViewBag.notification = "";
            StaticElement staticElement = _context.Get(StaticElementKey.OWNER);
            if (staticElement == null)
            {
                staticElement = new StaticElement(StaticElementKey.OWNER);
                ViewBag.notification = Notification.Warning("LƯU Ý", "Bạn chưa cung cấp tên của cá nhân hay tổ chức sở hữu");
            }
            return View(staticElement);
        }

        [HttpPost]
        public IActionResult Index(StaticElement staticElement)
        {
            ViewBag.notification = "";
            if (ModelState.IsValid)
            {
                if (staticElement == null)
                {
                    ViewBag.notification = Notification.Error("LỖI", "Nội dung nhập vào bị rỗng");
                    return View(staticElement);
                }
                else
                {
                    Console.WriteLine(staticElement.eId);
                    if (staticElement.eId <= 0)
                    {
                        Console.WriteLine(staticElement.createAt);
                        Console.WriteLine(staticElement.updateAt);
                        _context.Add(staticElement);
                    }
                    else
                    {
                        StaticElement _temp = _context.Get(StaticElementKey.OWNER);
                        if (_temp == null)
                        {
                            ViewBag.notification = Notification.Error("LỖI", "Không tìm thấy nội dung để cập nhật");
                            return View(staticElement);
                        }
                        else
                        {
                            _context.Update(_temp, staticElement);
                        }
                    }
                }
            }
            else
            {
                ViewBag.notification = Notification.Error("LỖI", "Nội dung nhập vào không hợp lệ");
                return View(staticElement);
            }
            ViewBag.notification = Notification.Error("XONG", "Cập nhật thành công");
            return View(staticElement);
        }
    }
}