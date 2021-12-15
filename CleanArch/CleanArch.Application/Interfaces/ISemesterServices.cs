using CleanArch.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfaces
{
    public interface ISemesterServices
    {
        SemesterDto Get(int id);
        SemestersDto GetAll();
        void Edit(int id, EditSemesterDto dto);
        void Delete(int id);
        void AddSemester(AddSemesterDto dto);
    }
}
