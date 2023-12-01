using Microsoft.AspNetCore.Mvc;
using Students_Detalis_Business.Interface;
using Students_Detalis_dbcontext.Students_Detalis_ViewModel;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Students_Details_Repo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IBusiness _IBusiness;
        public HomeController(IBusiness iBusiness)
        {
            _IBusiness = iBusiness;
        }
        [HttpGet("GET")]
        public object Getvalues()
        {
            var get = _IBusiness.Getvalues();
            return get;
        }
        [HttpPost("POST")]
        public object Postvalue(Students_model id)
        {
            var end = _IBusiness.Postvalue(id);
            return end;
        }
        [HttpPut("PUT")]
        public object Putvalue(int id, view VAF)
        {
            var update = _IBusiness.Putvalue(id,VAF);
            return update;
        }
        [HttpDelete("DELETE")]
        public object Deletevalue(int id)
        {
            var delete = _IBusiness.Deletevalue(id);
            return delete;
        }
    }
}
