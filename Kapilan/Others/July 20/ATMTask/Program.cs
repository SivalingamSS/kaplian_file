using BankingTasks;
using System;
namespace BankingTasks
{
    class Program1
    {
        public void Method1()
        {
            Console.WriteLine("WELCOME OUR VAF ATM SERVICES");
            Console.WriteLine("----------------------------");
            Console.WriteLine("ENTER YOUR PIN");

            int pin = 2003;
            int num = Convert.ToInt32(Console.ReadLine());
            {
                if (num == pin)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Welcome *********");
                    Console.WriteLine("1.Check Balance");
                    Console.WriteLine("2.Withdraw");
                    Console.WriteLine("3.Deposit");
                    Console.WriteLine("4.Quit");
                }
                else
                {
                    Console.WriteLine("Invalid Pin Please Try Again");
                }
            }
        }
    }
    class Program2 : Program1
    {
        public void Method2()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Please Enter Your Type");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 == 1)
            {
                Console.WriteLine("Your Balance Is 1500 Rupees Only");
            }
        }
    }
    class Program3 : Program2
    {
        public void Method3()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Please Enter Your Type");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int i = 1500;
            if (num2 == 2)
            {
                Console.WriteLine("Enter Your Amount");
                int num3 = Convert.ToInt32(Console.ReadLine());
                int num4 = i - num3;
                Console.WriteLine("Your Withdraw Successfull");
                Console.WriteLine("Your Balance Amount Is " + num4);
            }
        }
    }
    class Program4 : Program3
    {
        public void Method4()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Please Enter Your Type");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int i = 500;
            if (num2 == 3)
            {
                Console.WriteLine("Your Balance Amount Is 500 Rupees Only");
                Console.WriteLine("Enter Your Amount");
                int num5 = Convert.ToInt32(Console.ReadLine());
                int num6 = i + num5;
                Console.WriteLine("Your Withdraw Successfull");
                Console.WriteLine("Now,Your Balance Amount Is " + num6);
            }

        }
    }
    class Program5 :Program4
    {
        public void Method5()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Please Enter Your Type");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 == 4)
            {
                Console.WriteLine("THANK YOU FOR USING VAF ATM SERVICES");
            }
            else
            {
                Console.WriteLine("Invalid Options");
            }
        }
    }
}

class Program6 : Program5
{ 
public static void Main(string[] args)
        {

            Program6 bb = new Program6();
            bb.Method1();
            bb.Method2();
            bb.Method3();
            bb.Method4();
            bb.Method5();

        }
       
}