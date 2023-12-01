using Buisness_Layer.BInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Teacher;

namespace Authorization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Teacher : ControllerBase
    {
        public readonly IBusiness _ibusiness;
        public Teacher(IBusiness ibusiness)
        {
            _ibusiness = ibusiness;
        }
        [HttpPost("TeacherRegister")]
        public async Task<IActionResult> Reg(TeacherModel teach)
        {
            var got = await _ibusiness.Reg(teach);
            return Ok("Success");
        }
        [HttpGet("GetTeacher")]
        public async Task<IActionResult> GetTeacher(int id)
        {
            var view = await _ibusiness.GetTeacher(id);
            return Ok(view);
        }
    }
}
