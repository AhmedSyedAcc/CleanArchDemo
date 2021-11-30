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
            return _udc.Course.Single(x => x.Id == id);
        }

        public ICollection<Course> GetAll()
        {
            return _udc.Course.ToList();
        }

        public void Edit(Course course)
        {
            _udc.Update(course);
        }

        public void Add(Course course)
        {
            _udc.Course.Add(course);
        }

        public void Delete(int id)
        {
            Course course = _udc.Course.Find(id);
            _udc.Course.Remove(course);
        }

        public void Save()
        {
            _udc.SaveChanges();
        }
    }
}
