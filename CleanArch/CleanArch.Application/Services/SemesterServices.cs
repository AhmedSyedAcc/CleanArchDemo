using CleanArch.Application.Dtos;
using CleanArch.Application.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Domain.Repository;
using CleanArch.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class SemesterServices : ISemesterServices
    {
        private ISemesterRepository _semesterRepo; 

        public SemesterServices(ISemesterRepository semesterRepo)
        {
            _semesterRepo = semesterRepo;
        }

        public void AddSemester(AddSemesterDto dto)
        {
            //var courses = _courseRepository.GetAll().Where(x => dto.Courses.Contains(x.Id)).ToList();
            var semester = Semester.Create(dto.SemesterName);
            _semesterRepo.Add(semester);
            _semesterRepo.Save();
        }

        public void Delete(int id)
        {
            _semesterRepo.Delete(id);
        }

        public void Edit(int id, EditSemesterDto dto)
        {
            var semester = _semesterRepo.Get(id);
            semester.Edit(dto.SemesterName);
            _semesterRepo.Edit(semester);
            _semesterRepo.Save();
        }

        public SemesterDto Get(int id)
        {
            var semester = _semesterRepo.Get(id);
            var semesterDto = new SemesterDto();
            semesterDto.SemesterName = semester.SemesterName;
            semesterDto.Id = semester.Id;
            var courseDtos = new List<CourseDto>();

            foreach (var course in semester.Courses)
            {
                var courseDto = new CourseDto()
                {
                    Id = course.Id,
                    Name = course.Name,
                    Description = course.Description,
                    ImageUrl = course.ImageUrl
                };
                courseDtos.Add(courseDto);
            }

            semesterDto.Courses = courseDtos;
            return semesterDto;
        }

        public SemestersDto GetAll()
        {
            var semesters = _semesterRepo.GetAll();
            var semestersDto = new SemestersDto();
            var semesterDtos = new List<SemesterDto>();
            foreach (var semester in semesters)
            {
                var coursesDto = new List<CourseDto>();
                foreach (var course in semester.Courses)
                {
                    var courseDto = new CourseDto
                    {
                        Id = course.Id,
                        Name = course.Name,
                        Description = course.Name,
                        ImageUrl = course.ImageUrl
                    };
                    coursesDto.Add(courseDto);
                }

                var semesterDto = new SemesterDto()
                {
                    Id = semester.Id,
                    SemesterName = semester.SemesterName,
                    Courses = coursesDto
                };
                semesterDtos.Add(semesterDto);
            }
            semestersDto.Semesters = semesterDtos;
            return semestersDto;
        }
    }
}
