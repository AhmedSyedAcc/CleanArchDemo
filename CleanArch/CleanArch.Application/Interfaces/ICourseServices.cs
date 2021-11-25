using CleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseServices
    {
        CourseViewModel GetCourse();
        CourseViewModel EditCourse();
        CourseViewModel DeleteCourse(int id);
        CourseViewModel AddCourse();
    }
}
