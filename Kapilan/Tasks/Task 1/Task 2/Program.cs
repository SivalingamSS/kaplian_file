using System;

namespace Task_2
{
    public class Program
    {
        public void low()
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                {
                    Console.Write("\n");
                }
            }
            Console.WriteLine();
        }


        public void high()
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                { 
                    Console.Write("\n");
                }
            }

        }
        public static void Main(string[] args)
        {
            Program total = new Program();
            total.low();
            total.high();
        }
    }
}