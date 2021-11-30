using CleanArch.Application.Dtos;
using CleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        CourseDto Get(int id);
        CoursesDto GetAll();
        void Edit(int id, EditCourseDto dto);
        void Delete(int id);
        void AddCourse(AddCourseDto dto);
    }
}
