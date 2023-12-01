using BusinessLibrary.Interface;
using DBClass.Modal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Xml.Linq;

namespace Api_Databse_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        private readonly IBusiness _IBusiness;
        public ValuesController(IBusiness ibusiness)
        {
            _IBusiness = ibusiness;
        }
        [HttpGet("Get")]
        public async Task <IActionResult> GetValue()
        {
            var get = await _IBusiness.GetValue();
            return Ok(get);
        }
        [HttpPost("Post")]
        public async Task <IActionResult> PostValue(ViewModal id)
        {
            var post = await _IBusiness.PostValue(id);
            return Ok(post);
        }
        [HttpPut("Put")]
        public async Task<IActionResult> PutValue(int staffid,ViewModal modal)
        {
            var put = await _IBusiness.PutValue(staffid,modal);
            return Ok(put);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteValue(int id)
        {
            var delete = await _IBusiness.DeleteValue(id);
            return Ok(delete);
        }
    }
}
