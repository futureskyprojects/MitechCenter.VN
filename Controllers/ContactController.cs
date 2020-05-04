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
        public ContactController()
        {
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
