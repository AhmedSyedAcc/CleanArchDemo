using CleanArch.Application.Dtos;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Models;
using CleanArch.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseServices : ICourseService
    {
        private ICourseRepository _courseRepo;

        public CourseServices(ICourseRepository courseRepo)
        {
            _courseRepo = courseRepo;
        }

        public void AddCourse(AddCourseDto dto)
        {
            var course = Course.Create(dto.Name, dto.Description, dto.ImageUrl);
            _courseRepo.Add(course);
            _courseRepo.Save();
        }

        public void Delete(int id)
        {
            _courseRepo.Delete(id);
        }

        public void Edit(int id, EditCourseDto dto)
        {
            var course =  _courseRepo.Get(id);
            course.Edit(dto.Name, dto.Description, dto.ImageUrl);
            _courseRepo.Edit(course);
            _courseRepo.Save();
        }

        public CourseDto Get(int id)
        {
            return new CourseDto()
            {
                Course = _courseRepo.Get(id)
            };
        }

        public CoursesDto GetAll()
        {
            return new CoursesDto()
            {
                Courses = _courseRepo.GetAll()
            };
        }

    }
}
