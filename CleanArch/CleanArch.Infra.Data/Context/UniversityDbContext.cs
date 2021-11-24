using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions options)
            :base(options)
        {
        }

        public DbSet<Courses> Course { get; set; }
    }
}
