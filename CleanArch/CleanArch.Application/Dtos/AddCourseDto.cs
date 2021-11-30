using CleanArch.Domain.Models;
using System.Collections.Generic;

namespace CleanArch.Application.Interfaces
{
    public class AddCourseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}