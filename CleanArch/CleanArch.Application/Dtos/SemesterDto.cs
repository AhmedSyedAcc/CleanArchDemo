using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Dtos
{
    public class SemesterDto
    {
        public int Id { get; set; }
        public string SemesterName { get; set; }
        public ICollection<CourseDto> Courses { get; set; }
        public SemesterDto()
        {
            Courses = new List<CourseDto>();
        }
    }
}
