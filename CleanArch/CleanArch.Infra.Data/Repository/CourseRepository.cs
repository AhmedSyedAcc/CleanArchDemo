using CleanArch.Domain.Models;
using CleanArch.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepo
    {
        private UniversityDbContext _udc;

        public CourseRepository(UniversityDbContext udc)
        {
            _udc = udc;
        }

        public IEnumerable<Courses> GetCourse()
        {
            return _udc.Course;
        }
    }
}
