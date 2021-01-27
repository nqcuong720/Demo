using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Youtube.Application.MSinhVien;

namespace Youtube.WebApp.Services
{
    public interface IStudentAppClient
    {
        public Task<string> GetAll();

        public Task<string> Create(StudentRequest request);

        public Task<string> Update(StudentRequest request);

        public Task<string> Delete(StudentRequest request);
    }
}
