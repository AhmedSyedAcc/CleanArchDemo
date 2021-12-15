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
            var model = _courseServices.GetAll();
            return Ok(model);
        }
        public IActionResult Get(int id)
        {
            var model = _courseServices.Get(id);
            return Ok(model);
        }

        [HttpGet]
        public IActionResult AddCourse()
        {
            return Ok();
        }

       [HttpPost]
       public IActionResult AddCourse([FromBody]AddCourseDto dto)
        {
            if (ModelState.IsValid)
            {
                _courseServices.AddCourse(dto);
            }
            return Ok();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var course = _courseServices.Get(id);
            return Ok(course);
        }

        [HttpPost]
        public IActionResult Edit([FromBody] EditCourseDto dto)
        {
            if (ModelState.IsValid)
            {
                _courseServices.Edit(dto);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _courseServices.Delete(id);
            return Ok();
        }
    }
}
