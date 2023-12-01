using BUSINESS_LAYER.Interface;
using CUSTOMER_MODAL.Modal;
using Microsoft.AspNetCore.Mvc;

namespace CUSTOMER_DETAILS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly IBusiness _IBusiness;
        public HomeController(IBusiness ibusiness)
        {
            _IBusiness = ibusiness;
        }
        [HttpGet("GetValues")]
        public object GetValue()
        {
            var get = _IBusiness.GetValue();
            return get;
        }
        [HttpPost("PostValues")]
        public object PostValue(ModalClass id)
        {
            var post = _IBusiness.PostValue(id);
            return post;
        }
        [HttpPut("PutValues")]
        public object PutValue(int id, ViewModal Data)
        {
            var put = _IBusiness.PutValue(id,Data);
            return put;
        }
        [HttpDelete("DeleteValues")]
        public object DeleteValue(int id)
        {
            var delete = _IBusiness.DeleteValue(id);
            return delete;
        }
    }
}
