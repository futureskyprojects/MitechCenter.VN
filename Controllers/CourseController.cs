using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MitechCenter.vn.Models;
using MitechCenter.vn.Models.Repository;

namespace MitechCenter.vn.Controllers
{
    public class CourseController : Controller
    {
        private readonly IDataRepository<Course> _course;
        private readonly IDataRepository<Teacher> _teacher;
        public CourseController(IDataRepository<Course> course, IDataRepository<Teacher> teacher)
        {
            this._course = course;
            this._teacher = teacher;
        }
        public IActionResult Index()
        {
            ViewBag.Teachers = _teacher.GetAll();
            return View(_course.GetAll());
        }
    }
}