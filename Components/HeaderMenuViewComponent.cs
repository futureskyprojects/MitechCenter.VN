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
    public class HeaderMenuViewComponent : ViewComponent
    {
        private readonly IDataRepository<NewsCategory> _context;
        public HeaderMenuViewComponent(IDataRepository<NewsCategory> context)
        {
            this._context = context;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _context.GetAll();
            return View(categories);
        }
    }
}
