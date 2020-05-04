using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MitechCenter.vn.Models;
using MitechCenter.vn.Models.DataManager;
using MitechCenter.vn.Models.Repository;

namespace MitechCenter.vn.Controllers
{
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        private readonly IDataRepository<News> _context;
        private readonly IDataRepository<NewsCategory> _context_temp;
        public CategoryController(IDataRepository<News> context, IDataRepository<NewsCategory> context_temp)
        {
            this._context = context;
            this._context_temp = context_temp;
        }

        [HttpGet("{id}")]
        public IActionResult Index(string id)
        {
            if (id != null)
            {
                var arrs = id.Split("-");
                try
                {
                    var categoryId = Int64.Parse(arrs[arrs.Length - 1]);
                    var category = _context_temp.Get(categoryId);
                    var newCategories = _context_temp.GetAll();
                    ViewBag.news = ((NewsManager)_context).GetAll(categoryId);
                    ViewBag.newCategories = newCategories;
                    return View(category);
                }
                catch (Exception)
                {
                    // Không chuyển sang số được
                }
            }
            return NotFound();
        }
    }
}
