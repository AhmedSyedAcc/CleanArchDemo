using CleanArch.Application.Dtos;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.ViewModels
{
    public class CoursesDto
    {
        public ICollection<CourseDto> Courses { get; set; }
        public CoursesDto()
        {
            Courses = new List<CourseDto>();
        }
    }
}
