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
        public Semester Semester { get; set; }

        protected Course()
        {
                
        }

        protected Course(string name, string description, string imageUrl) : this()
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }

        public static Course Create(string name, string description, string imageUrl)
        {
            Console.WriteLine("Create Object");
            return new Course(name, description, imageUrl);
        }
        public void Edit(string name, string description, string imageUrl)
        {
            this.Name = name;
            this.Description = description;
            this.ImageUrl = imageUrl;
        }
    }
}
