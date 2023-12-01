using BusinessLayer.Interface;
using Common.Log;
using Common.Modal;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApp1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IBusiness _IBusiness;
       
        public ValuesController(IBusiness ibusinessr)
        {
            _IBusiness = ibusinessr;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                LogCreater.SuccessLog("Success", "SuccessLog");
                return Ok();
            }
            catch (Exception e)
            {
                LogCreater.ErrorLog("Here is error message from the controller.", "Catch");
            }
            return null;
        }
        [HttpPost("Post")]
        public async Task<IActionResult> Register(ViewModal use)
        {
            var get = await _IBusiness.Register(use);
            return Ok(get);
        }
    }
}
