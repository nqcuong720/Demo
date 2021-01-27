using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Youtube.Application.MSinhVien;
using Youtube.WebApp.Services;

namespace Youtube.WebApp.Controllers
{
    public class StudentController : Controller
    {
		private readonly IStudentAppClient _studentApipClient;

		public StudentController(IStudentAppClient sinhVienApiClient)
		{
			_studentApipClient = sinhVienApiClient;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var response = await _studentApipClient.GetAll();

			var model = JsonConvert.DeserializeObject<List<StudentResponse>>(response);

			return View(model);
		}

		// GET: api/<SinhVienController>
		[HttpGet]
		public async Task<IActionResult> Create()
		{
			return View();
		}

		// GET: api/<SinhVienController>
		[HttpPost]
		public async Task<IActionResult> Create(StudentRequest request)
		{
			try
			{
				// TODO: Add insert logic here 
				var response = await _studentApipClient.Create(request);

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}
	}
}
