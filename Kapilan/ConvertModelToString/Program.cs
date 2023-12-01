using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ConvertModelToString;


class Customer1
{
    public string Name { get; set; }
    public int Age { get; set; }
    public static void Main(string[] args)
    {

        var output = JsonConvert.DeserializeObject<Object2>("{ \"FirstName\":\"Captian\" , \"LastName\":\"Captian\", \"Age\":\"21\"}");
        //  var ujbnvjn = JsonConvert.DeserializeObject<Object2>(output);

        Console.WriteLine("FirstName" + output.FirstName);
        Console.WriteLine("LasNAme" + output.LastName);
        Console.WriteLine("Age" + output.Age);


        /* MainClass mainClass = new MainClass()
         {
             Name=mainClass.Name,

         };*/




        Console.WriteLine("2.Model  to Json string");
        var person = new
        {
            Name = "John",
            Age = 30,
            Address = "abcd",

            Street = "123 Main St",
            City = "New York",
            State = "NY"

        };

        string json = JsonConvert.SerializeObject(person, Formatting.Indented);
        //  var options = new JsonSerializerOptions { WriteIndented = true };
        Console.WriteLine(json + "\n");


        Console.WriteLine("3.Read Json File Assign The Modal");
        string test = File.ReadAllText(@"C:\Kapilan\Tasks\ConvertModelToString\jsconfig4.json");
        var test1 = JsonConvert.DeserializeObject<Object1>(test);
        string Hello = JsonConvert.SerializeObject(test1, Formatting.Indented);
        Console.WriteLine(Hello);


        Console.WriteLine("4.Json File To Get One Property");
        {
            string tet = File.ReadAllText(@"C:\Kapilan\Tasks\ConvertModelToString\jsconfig4.json");
            var show1 = JsonConvert.DeserializeObject<Object1>(tet);
            Console.WriteLine($"FirstName: {show1.FirstName + "\n"}");
        }



        Console.WriteLine("5.Json File To Get One Object");
        {
            string tet1 = File.ReadAllText(@"C:\Kapilan\Tasks\ConvertModelToString\jsconfig1.json");
            Object1[] ok = JsonConvert.DeserializeObject<Object1[]>(tet1);
            string Done = JsonConvert.SerializeObject(ok[0], Formatting.Indented);
            Console.WriteLine(Done + "\n");
        }



        Console.WriteLine("6.one object To Get One Property");
        {
            string tet2 = File.ReadAllText(@"C:\Kapilan\Tasks\ConvertModelToString\jsconfig1.json");
            Object1[] ok1 = JsonConvert.DeserializeObject<Object1[]>(tet2);
            Console.WriteLine($"Address: {ok1[0].Address}");
            Console.WriteLine("\n");
        }


        {
            string read = File.ReadAllText(@"C:\Kapilan\Tasks\ConvertModelToString\jsconfig1.json");
            Object1[] ok1 = JsonConvert.DeserializeObject<Object1[]>(read);
            string Done1 = JsonConvert.SerializeObject(ok1[0], Formatting.Indented);
            foreach (object item in Done1)
            {
                List<string> list = (List<string>)item;
                Console.WriteLine(list);
            }

        }



        Console.WriteLine("8.");
        Emp spaces = new Emp();
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { EmployeeName = "Vicky", EmployeeAddress = "Erode" });
            employees.Add(new Employee { EmployeeName = "Rocky", EmployeeAddress = "Namakkal" });
            spaces.Civil = employees;
            string Json = JsonConvert.SerializeObject(spaces, Formatting.Indented);
            string path = @"C:\Kapilan\Tasks\ConvertModelToString\jsconfig4.json";
            System.IO.File.WriteAllText(path, json);
            foreach (Employee Thar in employees)
            {
                Console.WriteLine(Thar);
            }
            space.Civil = employees;
            string Json = JsonConvert.SerializeObject(space, Formatting.Indented);
            string path = @"C:\Kapilan\Tasks\ConvertModelToString\jsconfig4.json";
            System.IO.File.WriteAllText(path, Json);
        }

        Console.WriteLine("9.Get Object To Push New Object");
        {
            string tet1 = File.ReadAllText(@"C:\Kapilan\JsonTasks\ConvertModelToString\jsconfig1.json");
            Object1[] ok = JsonConvert.DeserializeObject<Object1[]>(tet1);


            foreach (Object1 Employee in ok)
            {
                Object2 obj = new Object2()
                {
                    FirstName = Employee.FirstName,
                    LastName = Employee.LastName,
                    Age = Employee.Age,
                    Address = Employee.Address,
                    City = Employee.City,
                    State = Employee.State

                };
                if (obj.Age == 21)
                {
                    Console.WriteLine(obj.FirstName);
                    Console.WriteLine(obj.LastName);
                    Console.WriteLine(obj.Age);
                    Console.WriteLine(obj.Address);
                    Console.WriteLine(obj.City);
                    Console.WriteLine(obj.State);

                }
            }
        }

        Console.WriteLine("10.List Value Convert To Json");
        var varname = new List<Object2>(){
            new Object2() { FirstName = "Thiyaka" ,LastName = "Rajan",Age = 20,},
            new Object2() { FirstName = "Midhun",LastName = "Raj",Age = 22, }
            };

        var onename = new JsonSerializerOptions();
        string strJson = System.Text.Json.JsonSerializer.Serialize<IList<Object2>>(varname, onename);
        Console.WriteLine(strJson + "\n");



    }
}