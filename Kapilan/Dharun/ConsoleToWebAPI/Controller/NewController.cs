using Microsoft.AspNetCore.Mvc;
namespace ConsoleAppToWebAPI.Controllers
{
    [ApiController]
    [Route("NewApi/[action]")]
    public class NewController : ControllerBase
    {
        [HttpGet("get")]
        public string SayHii()
        {
            return "Hii Learners";
        }
    }
}