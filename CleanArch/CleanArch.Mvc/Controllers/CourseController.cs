using CleanArch.Application.Dtos;
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
        private ICourseService _courseServices;

        public CourseController(ICourseService courseServices)
        {
            _courseServices = courseServices;
        }

        public IActionResult Index()
        {
            CoursesDto model = _courseServices.GetAll();
            return View(model);
        }
        public IActionResult Get(int id)
        {
            CourseDto model = _courseServices.Get(id);
            return View(model);
        }

        [HttpGet]
        public IActionResult AddCourse()
        {
            return View();
        }

       [HttpPost]
       public IActionResult AddCourse(AddCourseDto dto)
        {
            if (ModelState.IsValid)
            {
                _courseServices.AddCourse(dto);
                return RedirectToAction("Index", "Course");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            CourseDto course = _courseServices.Get(id);
            return View(course);
        }

        [HttpPost]
        public IActionResult Edit(int id, EditCourseDto dto)
        {
            if (ModelState.IsValid)
            {
                _courseServices.Edit(id, dto);
                return RedirectToAction("Index", "Course");
            }
            else
                return View(dto);
        }

        [HttpGet]
        public IActionResult DeleteCourse(int id)
        {
            CourseDto course = _courseServices.Get(id);
            return View(course);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _courseServices.Delete(id);
            return RedirectToAction("Index", "Course");
        }
    }
}
