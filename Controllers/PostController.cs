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
    public class PostController : Controller
    {
        private readonly IDataRepository<News> _context;
        private readonly IDataRepository<NewsCategory> _context_temp;
        public PostController(IDataRepository<News> context, IDataRepository<NewsCategory> context_temp)
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
                    var newsId = Int64.Parse(arrs[arrs.Length - 1]);
                    var news = _context.Get(newsId);
                    var newCategories = _context_temp.GetAll();
                    ViewBag.news = ((NewsManager)_context).GetSize(5);
                    ViewBag.newCategories = newCategories;
                    ViewBag.nextNews = ((NewsManager)_context).getNextPost(newsId, news.ncId);
                    ViewBag.previousNews = ((NewsManager)_context).getPreviousPost(newsId, news.ncId);
                    return View(news);
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
