namespace FindPresent;

using Newtonsoft.Json;
using System;
using System.Net.Http.Json;

class Program
{
    static void Main()
    {

        string path = File.ReadAllText(@"C:\Kapilan\Find present Year\FindPresent\jsconfig1.json");


        Class1[] ok = JsonConvert.DeserializeObject<Class1[]>(path);
        DateTime date = DateTime.Now;

        foreach (var range in ok)
        {
            if (range.from <= date)
            {
                Console.WriteLine(range.from);
                Console.WriteLine(range.to);
            }
        }
    }
}

