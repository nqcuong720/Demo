using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Youtube.Application.MSinhVien;

namespace Youtube.WebApp.Services
{
    public class StudentAppClient : IStudentAppClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public StudentAppClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<string> Create(StudentRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44372");
            var response = await client.PostAsync("api/Student", httpContent);

            return await response.Content.ReadAsStringAsync();
        }

        public Task<string> Delete(StudentRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetAll()
        {
            
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44372");
            var response = await client.GetAsync("api/Student");

            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> Update(StudentRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44372");
            var response = await client.PutAsync("api/Student", httpContent);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
