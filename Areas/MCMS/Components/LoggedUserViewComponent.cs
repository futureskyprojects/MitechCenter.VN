using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MitechCenter.vn.Models;
using MitechCenter.vn.Models.DataManager;
using MitechCenter.vn.Models.Repository;

namespace MitechCenter.vn.Components
{
    public class LoggedUserViewComponent : ViewComponent
    {
        public LoggedUserViewComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
