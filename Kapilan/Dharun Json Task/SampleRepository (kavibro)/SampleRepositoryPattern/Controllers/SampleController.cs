using BLL.Sample.Interface;
using Microsoft.AspNetCore.Mvc;

namespace SampleRepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly ISampleBusiness _isampleBusiness;
        public SampleController(ISampleBusiness isampleBusiness)
        {
            _isampleBusiness=isampleBusiness;
        }

        [HttpGet]
        public  IActionResult Get()
        {
            string res = _isampleBusiness.getString();
            return Ok(res);
        }
    }
}
