using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Get_Url_Data.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Hosting_Data_url : ControllerBase
    {
        private readonly HttpClient _HttpClient;
        public Hosting_Data_url(HttpClient httpClient)
        {
            _HttpClient = httpClient;
        }
        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            string apiUrl = "http://192.168.0.252/api/Values/Get";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return Ok(content);
                }
                else
                {
                    return NotFound();
                }
            }
        }
        [HttpPost("Post")]
        public async Task<IActionResult> Post(Modal mod)
        {
            string apiUrl = "http://192.168.0.252/api/Values/Post";
            using (HttpClient client = new HttpClient())
            {
                var jsonData = JsonConvert.SerializeObject(mod);
                var content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                if (response.IsSuccessStatusCode)
                {
                    string contents = await response.Content.ReadAsStringAsync();
                    return Ok(contents);
                }
                else
                {
                    return NotFound();
                }
            }
        }
        [HttpPut("Put")]
        public async Task<IActionResult> Put(Modal mod)
        {
            string apiUrl = "http://192.168.0.252/api/Values/Put";
            using (HttpClient client = new HttpClient())
            {
                var jsonData = JsonConvert.SerializeObject(mod);
                var content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync(apiUrl, content);
                if (response.IsSuccessStatusCode)
                {
                    string contents = await response.Content.ReadAsStringAsync();
                    return Ok(contents);
                }
                else
                {
                    return NotFound();
                }
            }
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            string apiUrl = $"http://192.168.0.252/api/Values/Delete?id= + {id}";
            using (HttpClient client = new HttpClient())
            {
                var response = await client.DeleteAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string contents = await response.Content.ReadAsStringAsync();
                    return Ok(contents);
                }
                else
                {
                    return NotFound();
                }
            }
        }
    }
}
