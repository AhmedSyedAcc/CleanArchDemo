using CleanArch.Domain.Models;
using CleanArch.Domain.RepositoryInterface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{
    public class SemesterRepository : ISemesterRepository
    {
        private UniversityDbContext _udc;

        public SemesterRepository(UniversityDbContext udc)
        {
            _udc = udc;
        }

        public Semester Get(int id)
        {
            return _udc.Semesters.Include(x=> x.Courses).Single(x => x.Id == id);
        }

        public ICollection<Semester> GetAll()
        {
            return _udc.Semesters.ToList();
        }

        public void Edit(Semester semester)
        {
            _udc.Update(semester);
        }

        public void Add(Semester semester)
        {
            _udc.Semesters.Add(semester);
        }

        public void Delete(int id)
        {
            var semester = _udc.Semesters.Find(id);
            _udc.Semesters.Remove(semester);
        }

        public void Save()
        {
            _udc.SaveChanges();
        }
    }
}
