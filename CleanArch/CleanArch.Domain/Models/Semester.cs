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
        public ICollection<Course> Courses { get; protected set; }

        protected Semester()
        {

        }

        protected Semester(int id, string semesterName, ICollection<Course> courses)
        {
            Id = id;
            SemesterName = semesterName;
            Courses = courses;
        }
    }
}