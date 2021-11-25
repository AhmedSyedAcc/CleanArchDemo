using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseServices : ICourseServices
    {
        private ICourseRepo _courseRepo;

        public CourseServices(ICourseRepo courseRepo)
        {
            _courseRepo = courseRepo;
        }

        public CourseViewModel DeleteCourse(int id)
        {
            return new CourseViewModel()
            {
                Courses = _courseRepo.DeleteCourse(id)
            };
        }

        public CourseViewModel EditCourse()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepo.EditCourse()
            };
        }

        public CourseViewModel AddCourse()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepo.AddCourse()
            };
        }

        public CourseViewModel GetCourse()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepo.GetCourse()
            };
        }
    }
}
