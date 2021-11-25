using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Mvc.Controllers
{
    public class CourseController : Controller
    {
        private ICourseServices _courseServices;
        private UniversityDbContext universityDbContext;

        public CourseController(ICourseServices courseServices)
        {
            _courseServices = courseServices;
        }

        public IActionResult Index()
        {
            CourseViewModel model = _courseServices.GetCourse();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Courses model)
        {
            universityDbContext.Course.Add(model);
            universityDbContext.SaveChanges();
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            
            var data = universityDbContext.Course.Where(x => x.Id == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(Courses Model)
        {
            var data = universityDbContext.Course.Where(x => x.Id == Model.Id).FirstOrDefault();
            if (data != null)
            {
                data.ImageUrl = Model.ImageUrl;
                data.Name = Model.Name;
                data.Description = Model.Description;
                universityDbContext.SaveChanges();
            }

            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            var data = universityDbContext.Course.Where(x => x.Id == id).FirstOrDefault();
            universityDbContext.Course.Remove(data);
            universityDbContext.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
