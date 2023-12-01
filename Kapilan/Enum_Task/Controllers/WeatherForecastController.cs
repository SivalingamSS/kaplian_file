using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Reflection.PortableExecutable;

namespace Enum_Task.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet("Enum")]
        public object Method1()
        {
            var read = System.IO.File.ReadAllText(@"C:\Kapilan\Enum_Task\json.json");
            List<Main_data> assign = JsonConvert.DeserializeObject<List<Main_data>>(read);
            List<Main_data> game = new List<Main_data>();
            foreach(var data in assign)
            {
                data.Gender = (data.Gender == "0") ? Gender.Female.ToString() :Gender.Male.ToString();
                game.Add(data);
            }
            return game;
        }
    }
}
