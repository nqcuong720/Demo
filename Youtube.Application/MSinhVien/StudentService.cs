using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youtube.Data.EntitiesModel;
using Youtube.Data.YoutubeContext;

namespace Youtube.Application.MSinhVien
{
    public class StudentService : StudentIServices
    {
        private readonly YoutubeEntitesContext _context;
        public StudentService(YoutubeEntitesContext context)
        {
            _context = context;
        }
        public async Task<int> Create(StudentRequest student)
        {
            Student sv = new Student(){ 
                StudentName = student.StudentName,
                Address = student.Address,
            };
            _context.Student.Add(sv);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(StudentRequest student)
        {
            var sv = new Student()
            {
                StudentId = student.StudentId
            };
            _context.Student.Remove(sv);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<StudentResponse>> GetAll()
        {
            var response =  _context.Student.Select(s => new StudentResponse()
            {
                StudentId = s.StudentId,
                StudentName = s.StudentName,
                Address = s.Address
            }).ToListAsync();
            return await response;
        }

        public async Task<int> Update(StudentRequest student)
        {
            var sv = new Student()
            {
                StudentId = student.StudentId,
                StudentName = student.StudentName,
                Address = student.Address,
            };
            _context.Student.Update(sv);
            return await _context.SaveChangesAsync();
        }
    }
}
