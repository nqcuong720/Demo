using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Youtube.Application.MSinhVien;


namespace Youtube.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentIServices _studentIServices;
        public StudentController(StudentIServices studentIServices)
        {
            _studentIServices = studentIServices;
        }
        // GET: api/<StudentController>
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await _studentIServices.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] StudentRequest request)
        {
            var status = await _studentIServices.Create(request);
            return Ok(status);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] StudentRequest request)
        {
            var status = await _studentIServices.Update(request);
            return Ok(status);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] StudentRequest request)
        {
            var status = await _studentIServices.Delete(request);
            return Ok(status);
        }

    }
}
