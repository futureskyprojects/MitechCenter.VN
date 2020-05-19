using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MitechCenter.vn.Models;
using MitechCenter.vn.Models.DataManager;
using MitechCenter.vn.Models.Repository;

namespace MitechCenter.vn.Controllers
{
    public class ContactController : Controller
    {
        private readonly IDataRepository<Feedback> _feedback;
        public ContactController(IDataRepository<Feedback> feedback)
        {
            this._feedback = feedback;
        }
        public IActionResult Index()
        {
            return View(new Feedback());
        }

        [HttpPost]
        public IActionResult SendContact(Feedback feedback)
        {
            feedback.fAddress = "Phản hồi đến từ [LIÊN HỆ]";
            _feedback.Add(feedback);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult SendFeedback(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _feedback.Add(feedback);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
