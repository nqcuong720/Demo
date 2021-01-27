using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Youtube.Application.MSinhVien
{
    public interface StudentIServices
    {
        public Task<int> Create(StudentRequest student);
        public Task<int> Update(StudentRequest student);
        public Task<int> Delete(StudentRequest student);
        public Task<List<StudentResponse>> GetAll();
    }
}
