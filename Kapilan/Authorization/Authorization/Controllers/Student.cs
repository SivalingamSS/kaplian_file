using Buisness_Layer.BInterface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Model;
using Model.Teacher;
using Model.ViewModal;

namespace Authorization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Student : ControllerBase
    {
        public readonly IBusiness _ibusiness;
        public Student(IBusiness ibusiness)
        {
            _ibusiness = ibusiness;
        }
        [HttpPost("RegisterStudent")]
        public async Task<IActionResult> Register(StudentModel stud)
        {
            var get = await _ibusiness.Register(stud);
            return Ok("Success");
        }
        [HttpPost("TokenGenerate")]
        public async Task<IActionResult> Login(string name, string password)
        {
            var login = await _ibusiness.Login(name, password);
            return Ok(login);

        }
        [Authorize(Roles = "Student")]
        [HttpGet("Getstudentid")]
        public async Task<IActionResult> GetStudent(int id)
        {
            var view = await _ibusiness.GetStudent(id);
            return Ok(view);
        }
        [HttpPut("Update")]
        public async Task<StudentModel> PutStudent(int id,UserModel put)
        {
            var win=await _ibusiness.PutStudent(id, put);
            return win;
        }
    }
}
            