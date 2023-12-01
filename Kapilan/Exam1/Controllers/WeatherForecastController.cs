using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace Exam1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet("Get")]
        public object Method1()
        {
            string file = System.IO.File.ReadAllText(@"C:\Kapilan\Exam1\Mainjsconfig.json");
            Root[] value = JsonConvert.DeserializeObject<Root[]>(file);
            List<Root> list = new List<Root>();
            foreach (var output in value)
            {
                list.Add(output);
            }
            return list;
        }
        [HttpGet("Gets")]
        public object Method2()
        {
            int GetDaysInYear(DateTime date)

            {
                if (date.Equals(DateTime.MinValue))
                {
                    return -1;
                }

                DateTime thisYear = new DateTime(date.Year, 1, 1);
                DateTime nextYear = new DateTime(date.Year + 1, 1, 1);

                return (nextYear - thisYear).Days;
            }
            return 0;
        }
    }
}

