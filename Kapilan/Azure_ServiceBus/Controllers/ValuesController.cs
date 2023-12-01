using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using Microsoft.Azure.ServiceBus;
using Azure_ServiceBus.Modal;
using Azure_ServiceBus.Interface;

namespace Azure_ServiceBus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IServiceBus _serviceBus;
        public ValuesController(IServiceBus serviceBus)
        {
            _serviceBus = serviceBus;
        }
        [HttpPost("OrderDetails")]
        public async Task<IActionResult> OrderDetails(CarDetails carDetails)
        {
            if (carDetails != null)
            {
                await _serviceBus.SendMessageAsync(carDetails);
            }
            return Ok();
        }
    }
}