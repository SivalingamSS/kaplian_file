using Microsoft.AspNetCore.Mvc;
using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json;
using Tasks;
namespace Tasks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Task : ControllerBase
    {
        [HttpGet("1.String Convert to Model")]
        public object get1()
        {
            var output = JsonConvert.DeserializeObject<MainClass>("{ \"Name\":\"CaptianAmerica\" , \"Age\":\"21\", \"Department\":\"Science\", \"City\":\"Kolkata\", \"School\":\"Pavaai Institutions\", \"Location\":\"Kadugodi\"}");
            return output;
        }
        [HttpGet("2.Model Convert To Json File")]
        public object get2()
        {
            var person = new
            {
                Name = "Johnwick",
                Age = 30,
                Address = "Paris",
                Street = "123 Main St",
                City = "New York",
                State = "NewZealand"
            };
            var json = JsonConvert.SerializeObject(person, Formatting.Indented);
            string path = (@"C:\Kapilan\JsonTasks\Tasks\jsconfig1.json");
            System.IO.File.WriteAllText(path, json);
            return json;
        }


        [HttpGet("3.Read Json File Assign The Model")]
        public object get3()
        {
            string output1 = System.IO.File.ReadAllText(@"C:\Kapilan\JsonTasks\Tasks\Mainjsconfig.json");
            object[] output2 = JsonConvert.DeserializeObject<MainClass[]>(output1);
            var output3 = JsonConvert.SerializeObject(output2[0], Formatting.Indented);
            return output3;
        }

        [HttpGet("4.Json To Get One Property")]
        public object get4()
        {
            {
                string test = System.IO.File.ReadAllText(@"C:\Kapilan\JsonTasks\Tasks\Mainjsconfig.json");
                MainClass[] test1 = JsonConvert.DeserializeObject<MainClass[]>(test);
                var Cal = $" Name: {test1[2].Name}";
                return Cal;
            }
        }

        [HttpGet("5.Json Array Of Objects To Get One Object To Show")]
        public object get5()
        {
            string Variable = System.IO.File.ReadAllText(@"C:\Kapilan\JsonTasks\Tasks\Mainjsconfig.json");
            MainClass[] ok = JsonConvert.DeserializeObject<MainClass[]>(Variable);
            string Done = JsonConvert.SerializeObject(ok[0], Formatting.Indented);
            return Done;
        }
        [HttpGet("6.Json Array Of Objects To Get One Object In One Property To Show")]
        public object get6()
        {
            string tet2 = System.IO.File.ReadAllText(@"C:\Kapilan\JsonTasks\Tasks\Mainjsconfig.json");
            MainClass[] yes = JsonConvert.DeserializeObject<MainClass[]>(tet2);
            var Cal = $" Age: {yes[1].Age}";
            return Cal;
        }
        [HttpGet("7.Json Array Of Objects To Get One Object To Push New List")]
        public object get7()
        {
            string test2 = System.IO.File.ReadAllText(@"C:\Kapilan\JsonTasks\Tasks\Mainjsconfig.json");
            MainClass[] no = JsonConvert.DeserializeObject<MainClass[]>(test2);
            List<MainClass> jsons = new List<MainClass>();
            for (int i = 0; i < no.Length; i++)
            {
                if (no[i].Name == "Naveen")
                {
                    jsons.Add(no[i]);
                }
            }
            return jsons;
        }
        [HttpGet("8.Json Array Of Objects To Get Multiple Object To Push New List")]
        public object get8()
        {
            string test4 = System.IO.File.ReadAllText(@"C:\Kapilan\JsonTasks\Tasks\Mainjsconfig.json");
            MainClass[] noo = JsonConvert.DeserializeObject<MainClass[]>(test4);
            List<MainClass> jsonss = new List<MainClass>();

            for (int i = 0; i < noo.Length; i++)

            {
                if (noo[i].Age < 22)
                {
                    jsonss.Add(noo[i]);
                }
            }
            return jsonss;
        }

        [HttpGet("9.Json Array Of Objects To Get Object To Push New Object")]
        public object get9()
        {
            string tet1 = System.IO.File.ReadAllText(@"C:\Kapilan\JsonTasks\Tasks\Mainjsconfig.json");
            MainClass[] okey = JsonConvert.DeserializeObject<MainClass[]>(tet1);

            foreach (MainClass Employee in okey)
            {
                MainClass1 Format = new MainClass1()
                {
                    StudentName = Employee.Name,
                    StudentAge = Employee.Age,
                    StudentDepartment = Employee.Department,
                    StudentCity = Employee.City,
                    StudentSchool = Employee.School,
                    StudentLocation = Employee.Location
                };
                return Format;
            }
            return 0;
        }
        [HttpGet("10.Json Array Of Object List Value Convert To Json")]
        public object get10()
        {
            var varname = new List<MainClass>(){
            new MainClass() { Name = "Thiyaka" ,Age = 20,Department = "Science",City = "Namakkal",School = "Vinayaga",Location = "Tamilnadu"},
            new MainClass() { Name = "Midhun",Age = 22,Department = "Social",City = "Salem",School = "Vetri",Location = "Kerala"}
            };
            string strJson = JsonConvert.SerializeObject(varname, Formatting.Indented);
            return strJson;
        }
        [HttpGet("11.Read Json File To Show Unique And Duplicate Object.There Is Two List For Unique And Duplicates")]
        public object get11()
        {
            string json = System.IO.File.ReadAllText(@"C:\Kapilan\JsonTasks\Tasks\Mainjsconfig.json");
            MainClass[] array = JsonConvert.DeserializeObject<MainClass[]>(json);
            List<MainClass> Duplicate = new List<MainClass>();
            List<MainClass> Unique = new List<MainClass>();
            foreach (MainClass arrays in array)
            {
                if (arrays.Age == 22)
                {
                    Duplicate.Add(arrays);
                }
                else
                {
                    Unique.Add(arrays);
                }
            }
            return new { Duplicate, Unique };
        }
    }
}
