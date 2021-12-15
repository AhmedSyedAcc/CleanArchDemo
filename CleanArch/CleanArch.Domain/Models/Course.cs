using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Models
{
    public class Course
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string ImageUrl { get; protected set; }
        public Semester Semester { get; protected set; }
        public int SemesterId { get; protected set; }

        protected Course()
        {
                
        }

        protected Course(string name, string description, string imageUrl, int semesterId) : this()
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
            SemesterId = semesterId;
        }

        public static Course Create(string name, string description, string imageUrl, int semesterId)
        {
            Console.WriteLine("Create Object");
            return new Course(name, description, imageUrl, semesterId);
        }
        public void Edit(string name, string description, string imageUrl)
        {
            this.Name = name;
            this.Description = description;
            this.ImageUrl = imageUrl;
        }
        public void ChangeSemester(int semesterId)
        {
            this.SemesterId = semesterId;
        }
    }
}
