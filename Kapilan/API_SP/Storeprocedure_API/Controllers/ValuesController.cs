using BusiinessLibrary.Interface;
using DBClass.ViewModal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Storeprocedure_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly BusinessInterface _businessInterface;
        public ValuesController (BusinessInterface businessInterface)
        {
            _businessInterface = businessInterface;
        }
        [HttpGet("GET_SP")]
        public async Task <IActionResult> GET_SP()
        {
            var get = await _businessInterface.GET_SP();
            return Ok(get);
        }
        [HttpPost("POST_SP")]
        public async Task<object> POST_SP(ViewClass view)
        {
            var post = await _businessInterface.POST_SP(view);
            return Ok(post);
        }
        [HttpPut("PUT_SP")]
        public async Task<object> PUT_SP(ViewClass view)
        {
            var put = await _businessInterface.PUT_SP(view);
            return Ok(put);
        }
        [HttpDelete("DELETE_SP")]
        public async Task <object> DELETE_SP(int id)
        {
            var delete = await _businessInterface.DELETE_SP(id);
            return Ok(delete);
        }
    }
}
