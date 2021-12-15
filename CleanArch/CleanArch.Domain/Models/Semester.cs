using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Models
{
    public class Semester
    {
        public int Id { get; protected set; }
        public string SemesterName { get; protected set; }
        private readonly List<Course> _courses;
        public IEnumerable<Course> Courses => _courses.AsReadOnly();

        //internal void AddCourses(IList<Course> courses)
        //{
        //    foreach (var course in courses)
        //    {
        //        if (!Courses.Any(x => x.Id == course.Id))
        //        {
        //            Courses.Add(course);
        //        }
        //    }
        //}

        protected Semester()
        {
            _courses = new List<Course>();
        }

        protected Semester(string semesterName)
            : this()
        {
            SemesterName = semesterName;
        }

        public static Semester Create( string semesterName)
        {
            return new Semester(semesterName);
        }
        public void Edit(string semesterName)
        {
            this.SemesterName = semesterName;
        }
        
    }
}