using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MitechCenter.vn.Models;
using MitechCenter.vn.Models.DataManager;
using MitechCenter.vn.Models.Repository;

namespace MitechCenter.vn.Components
{
    public class LoggedUserViewComponent : ViewComponent
    {
        private readonly IDataRepository<User> _context;
        public LoggedUserViewComponent(IDataRepository<User> context)
        {
            this._context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
