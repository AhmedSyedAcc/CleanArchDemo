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
            var course = Course.Create(dto.Name, dto.Description, dto.ImageUrl, dto.SemesterId);
            _courseRepo.Add(course);
            _courseRepo.Save();
        }

        public void Delete(int id)
        {
            _courseRepo.Delete(id);
        }

        public void Edit(EditCourseDto dto)
        {
            var course =  _courseRepo.Get(dto.Id);
            course.Edit(dto.Name, dto.Description, dto.ImageUrl);
            //course.ChangeSemester(id);
            _courseRepo.Edit(course);
            _courseRepo.Save();
        }

        public CourseDto Get(int id)
        {
            var course = _courseRepo.Get(id);
            var courseDto = new CourseDto();
            courseDto.Id = course.Id;
            courseDto.Name = course.Name;
            courseDto.Description = course.Description;
            courseDto.ImageUrl = course.ImageUrl;
            courseDto.SemesteId = course.SemesterId;
            return courseDto;
        }

        public CoursesDto GetAll()
        {
            var courses = _courseRepo.GetAll();
            var coursesDto = new CoursesDto();
            var courseDtos = new List<CourseDto>();
            foreach (var course in courses)
            {
                var courseDto = new CourseDto()
                {
                    Id = course.Id,
                    Name = course.Name,
                    Description = course.Description,
                    ImageUrl = course.ImageUrl
                };
                courseDtos.Add(courseDto);
            }
            coursesDto.Courses = courseDtos;
            return coursesDto;
        }

    }
}
