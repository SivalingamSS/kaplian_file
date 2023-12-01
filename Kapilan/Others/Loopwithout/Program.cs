using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<String> numbers = new List<String> {"Kabilan"};

        // Loop using LINQ extension methods
        numbers.Aggregate((x, y) =>
        {
            Console.WriteLine(x);
            return y;
        });
    }
}
