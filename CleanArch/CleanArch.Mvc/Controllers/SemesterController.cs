using CleanArch.Application.Dtos;
using CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Mvc.Controllers
{
    public class SemesterController : Controller
    {
        private ISemesterServices _semesterServices;

        public SemesterController(ISemesterServices semesterServices) 
        {
            _semesterServices = semesterServices;
        }

        public IActionResult Index()
        {
           var model = _semesterServices.GetAll();
            return Ok(model);
        }
        public IActionResult Get(int id)
        {
            var model = _semesterServices.Get(id);
            return Ok(model);
        }

        [HttpGet]
        public IActionResult AddSemester()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddSemester([FromBody] AddSemesterDto dto)
        {
            if (ModelState.IsValid)
            {
                _semesterServices.AddSemester(dto);
            }
            return Ok();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var semester = _semesterServices.Get(id);
            return Ok(semester); 
        }

        [HttpPost]
        public IActionResult Edit(int id, EditSemesterDto dto)
        {
            if (ModelState.IsValid)
            {
                _semesterServices.Edit(id, dto);
                return Ok();
            }
            else
                return Ok(dto);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _semesterServices.Delete(id);
            return Ok();
        }
    }
}
