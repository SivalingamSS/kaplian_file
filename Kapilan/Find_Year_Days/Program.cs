using System;
using System.Globalization;

namespace Find_Year_Days
{
    public class Program
    {
        int inputYear;
        public void Find_Leap_Not()
        {
            Console.WriteLine("Enter Your Year");
            inputYear = int.Parse(Console.ReadLine());
            if (inputYear % 4 == 0)
            {
                Console.WriteLine("Is Leap Year :"+ inputYear);
            }
            else
            {
                Console.WriteLine("Not a Leap Year :"+ inputYear);
            }
        }
        public void Find_Days_In_Month()
        {
            Console.WriteLine("Enter month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Days in the month :" + DateTime.DaysInMonth(inputYear, month));
        }
        public void Find_Weeks_In_Year()
        {
            Console.WriteLine("There are " + ISOWeek.GetWeeksInYear(inputYear) + $" Weeks in a {inputYear} Year");
        }
        public void Find_Days_in_Year()
        {
                int days = 0;
                for (int i = 1; i <= 12; i++)
                {
                    days += DateTime.DaysInMonth(inputYear, i);
                }
            Console.WriteLine("There Are " + days + " Days in a " + inputYear + " Year");
        }
        public void Find_Month_days()
        {
            int a = 0,b=0,c=0;
            for (int i = 1; i <= 12; i++)
            {
                int Total = DateTime.DaysInMonth(inputYear,i);
                var output = (Total == 31) ? a++ : (Total == 30) ? b++ : c++; 
            }
            Console.WriteLine("31 Ends On "+a+" Months");
            Console.WriteLine("30 Ends On "+b +" Months");
            Console.WriteLine("Others Ends On " + c + " Months");
        }
        public static void Main(string[] args)
        {
            Program cal = new Program();
            cal.Find_Leap_Not();
            cal.Find_Weeks_In_Year();
            cal.Find_Days_in_Year();
            cal.Find_Days_In_Month();
            cal.Find_Month_days();
        }
    }
}
