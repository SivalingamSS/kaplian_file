using Business_Layer.Interface_BL;
using DOT;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace curd_repository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IBusiness _ibusiness;
        public ValuesController(IBusiness ibusiness)
        {
            _ibusiness = ibusiness;
        }

        [HttpPost("post")]
        public ActionResult post(View name)
        {
            var per = _ibusiness.POST(name);
            return Ok(per);
        }
        [HttpGet("get")]
        public ActionResult get()
        {
            var p = _ibusiness.GET();
            return Ok(p);
        }
        [HttpPut("put")]
        public ActionResult put(View detials)
        {
            var b = _ibusiness.PUT(detials);
            return Ok(b);
        }
        [HttpDelete("delete")]
        public ActionResult delete(int id)
        {
            var d = _ibusiness.DELETE(id);
            return Ok(d);
        }
    }
}