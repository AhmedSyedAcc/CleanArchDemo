using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Repository
{
    public interface ICourseRepository
    {
        Course Get(int id);
        ICollection<Course> GetAll();
        void Edit(Course course);
        void Add(Course course);
        void Delete(int id);
        void Save();
    }
}
