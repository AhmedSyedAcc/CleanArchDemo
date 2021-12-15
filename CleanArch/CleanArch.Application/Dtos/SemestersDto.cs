using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Dtos
{
    public class SemestersDto
    {
        public ICollection<SemesterDto> Semesters { get; set; }
        public SemestersDto()
        {
            Semesters = new List<SemesterDto>();
        }
    }
}
