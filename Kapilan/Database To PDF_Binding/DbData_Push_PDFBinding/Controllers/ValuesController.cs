using BusinessLibrary.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Crypto.Tls;
using System.ComponentModel.DataAnnotations;

namespace DbData_Push_PDFBinding.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IBusiness _business;
        public ValuesController(IBusiness business)
        {
            _business = business;
        }
        [HttpGet("GetData")]
        public async Task <IActionResult> GetData(int id)
        {
            var data = await _business.GetData(id);
            return File(data);
        }
    }
}
