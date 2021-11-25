using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Repository
{
    public interface ICourseRepo
    {
        IEnumerable<Courses> GetCourse();
        IEnumerable<Courses> EditCourse();
        IEnumerable<Courses> AddCourse();
        IEnumerable<Courses> DeleteCourse(int id);
    }
}
