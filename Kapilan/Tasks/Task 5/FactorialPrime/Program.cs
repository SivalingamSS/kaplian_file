using System.Threading.Channels;

namespace FactorialPrime
{
     class Program
    {
        public virtual int method1()
        {
            Console.WriteLine("Enter Your Number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }

            if (a == 2)
            {
                Console.WriteLine("is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("is not a Prime Number");
            }
            Console.WriteLine("\n");
            return 0;
        }
    }
     class Program2 : Program
    {
        public override int method1()
        {
            int i, fact = 1, number;
            Console.WriteLine("Enter Your Factorial Number:");
            number = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i < number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + number + " is " +  fact);
            return 0;
        }
    }
    class Program3
    {
        public static void Main(string[] args)
        {
            Program obj = new Program();
            obj.method1();
            Program2 ob = new Program2();
            ob.method1();
        }
    }
}