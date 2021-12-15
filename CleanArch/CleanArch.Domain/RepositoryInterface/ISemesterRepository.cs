using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.RepositoryInterface
{
    public interface ISemesterRepository
    {
        Semester Get(int id);
        ICollection<Semester> GetAll();
        void Edit(Semester semester);
        void Add(Semester semester);
        void Delete(int id);
        void Save();
    }
}
