using CleanArch.Domain.Models;
using CleanArch.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    { 
        private UniversityDbContext _udc;

        public CourseRepository(UniversityDbContext udc)
        {
            _udc = udc;
        }

        public Course Get(int id)
        {
            return _udc.Courses.Single(x => x.Id == id);
        }

        public ICollection<Course> GetAll()
        {
            return _udc.Courses.ToList();
        }

        public void Edit(Course course)
        {
            _udc.Courses.Update(course);
        }

        public void Add(Course course)
        {
            _udc.Courses.Add(course);
        }

        public void Delete(int id)
        {
            Course course = _udc.Courses.Find(id);
            _udc.Courses.Remove(course);
        }

        public void Save()
        {
            _udc.SaveChanges();
        }
    }
}
