using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Dtos
{
    public class EditSemesterDto
    {
        public string SemesterName { get; set; }
        public ICollection<CourseDto> Courses { get; set; }
        public EditSemesterDto()
        {
            Courses = new List<CourseDto>();
        }
    }
}
