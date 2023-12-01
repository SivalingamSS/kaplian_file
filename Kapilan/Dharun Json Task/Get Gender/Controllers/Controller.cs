using Get_Gender.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Get_Gender.Controllers
{
   
    public class Controller : ControllerBase
    {
        [HttpGet("Enums")]
        public object get()
        {
            string path = System.IO.File.ReadAllText(@"E:\seran\Dharun\C#\Josn Aug14\Get Gender\Gender.json");
           // var my = JsonConvert.DeserializeObject(path);
            List<Root> me = JsonConvert.DeserializeObject<List<Root>>(path);
            List<Root> result = new List<Root>();
            foreach(var per in me)
            {
                 per.Gender =per.Gender== "0" ? "Male" : "Female";
                 result.Add(per);
            }
            return result;
        }
    }
}
