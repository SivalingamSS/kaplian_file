using ConsoleApp1;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace ConsoleApp1
{
    class Program
    {
        int amount = 1500;
        public void m1()
        {
            Console.WriteLine("Your Current Balance Is:" + amount + " Rupees Only");
            Console.WriteLine("----------------------------");
            Console.WriteLine("\n");
        }
        public void m2()
        {
            Console.WriteLine("Enter Your Withdraw Amount");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (amount > num2)
            {
                if (num2 % 500 == 0)
                {
                    amount -= num2;
                    Console.WriteLine("Your Withdraw Successful");
                    Console.WriteLine("Now Your Balance is: " + amount + " Rupees Only");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("\n");
                }
                else if(num2 >(amount - 500))
                {
                    Console.WriteLine("Insufficient Balance");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("no balance");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("\n");
                }
            }
            else
            {
                Console.WriteLine("minimum blance not available");
                Console.WriteLine("----------------------------");
                Console.WriteLine("\n");
            }
        }
        public void m3()
        {
            Console.WriteLine("Enter Your Deposit Amount");
            int num3 = Convert.ToInt32(Console.ReadLine());
            amount += num3;
            Console.WriteLine("Your Deposit Was Successfull");
            Console.WriteLine("Now,Your Balance Is:" + amount + " Rupees Only");
            Console.WriteLine("----------------------------");
            Console.WriteLine("\n");
        }
        public void m4()
        {
            Console.WriteLine("THANK YOU FOR USING VAF ATM SERVICES");
            Console.WriteLine("----------------------------");
        }
    }
    class Program32 : Program
    {
        public void Method()
        {

            Console.WriteLine("WELCOME OUR VAF ATM SERVICES");
            Console.WriteLine("----------------------------");
            Console.WriteLine("ENTER YOUR PIN");
            for (int i = 0; i < 3; i++)
            {
                //int pin = 2003;
                string pin = "2003";
                string num = Convert.ToString(Console.ReadLine());
                if (num == pin)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("WELCOME TO OUR VAF ATM SERVICES");
                    Console.WriteLine("1.CHECK BALANCE");
                    Console.WriteLine("2.WITHDRAW");
                    Console.WriteLine("3.DEPOSIT");
                    Console.WriteLine("4.QUIT");
                    Console.WriteLine("\n");

                    for (int t = 0; true; t++)
                    {
                        Console.WriteLine("Please Enter Your Choice");
                        //int gg = int.Parse(Console.ReadLine());
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        switch (num1)
                        {
                            case 1:
                                m1();
                                break;
                            case 2:
                                m2();
                                break;
                            case 3:
                                m3();
                                break;
                            case 4:
                                m4();
                                return;
                            default:
                                Console.WriteLine("Not Matched Please Enter The Correct Pin ");
                                Console.WriteLine("\n");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Pin,Please Try Again");
                    Console.WriteLine("\n");
                }

            }
            Console.WriteLine("You Have Ateempted 3 Incorrect pins");
            Console.WriteLine("\n");
            return;
        }
    }
}

class Program2 : Program32
{
    public static void Main(string[] args)
    {
        Program2 cal = new Program2();
        cal.Method();
    }

}

