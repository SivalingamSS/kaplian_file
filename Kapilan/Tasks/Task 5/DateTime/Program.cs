using System;
namespace datemonth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The First Date (yyyy-mm-dd):");
            DateTime Firstdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Second Date (yyyy-mm-dd):");
            DateTime Seconddate = DateTime.Parse(Console.ReadLine());
            TimeSpan DB = Seconddate - Firstdate;
            int numberofDays = DB.Days;
            int month = (Firstdate - Seconddate).Days / 30;
            Console.WriteLine("Number of Month:" + month);
            Console.WriteLine("Number of Days between two Days:" + numberofDays);

        }
    }
}