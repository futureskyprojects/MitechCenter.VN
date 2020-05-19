
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MitechCenter.vn.Models;
using MitechCenter.vn.Models.Repository;
using System.Linq;

namespace MitechCenter.vn.Areas.MCMS.Controllers
{
    [Area("MCMS")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IDataRepository<NewsCategory> _newCategories;
        private readonly IDataRepository<News> _news;
        private readonly IDataRepository<Teacher> _teacher;
        private readonly IDataRepository<Course> _course;
        private readonly IDataRepository<User> _user;
        private readonly IDataRepository<Feedback> _feedback;
        public HomeController(IDataRepository<NewsCategory> newCategories, IDataRepository<News> news, IDataRepository<Teacher> teacher, IDataRepository<Course> course, IDataRepository<User> user, IDataRepository<Feedback> feedback)
        {
            this._newCategories = newCategories;
            this._news = news;
            this._teacher = teacher;
            this._course = course;
            this._user = user;
            this._feedback = feedback;
        }
        public IActionResult Index()
        {
            ViewBag.newsCategoryCount = _newCategories.GetAll().Count();
            ViewBag.newsCount = _news.GetAll().Count();
            ViewBag.teacherCount = _teacher.GetAll().Count();
            ViewBag.courseCount = _course.GetAll().Count();
            ViewBag.feedbacks = _feedback.GetAll();

            return View(_user.GetAll());
        }
    }
}