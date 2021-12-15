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

        public DbSet<Course> Courses { get; set; }
        public DbSet<Semester> Semesters { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Semester>()
                .Metadata.FindNavigation(nameof(Semester.Courses))
                .SetPropertyAccessMode(PropertyAccessMode.Field);
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Course>()
        //        .HasRequired<Semester>(b => b.Semester)
        //        .WithMany(a => a.Courses)
        //        .HasForeignKey<int>(b => b.SemesterId);
        //}
    }
}
