namespace ArithmeticProtected
{
    internal class Arithmetic
    {
        protected void addition()
        {
            Console.WriteLine("Addition:");
            Console.WriteLine("Enter Your First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("Addition is :" + sum);
            Console.WriteLine("\n");
        }

        protected void subraction()

        {
            Console.WriteLine("Subraction:");
            Console.WriteLine("Enter Your First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 - num2;
            Console.WriteLine("Subraction is :" + sum);
            Console.WriteLine("\n");
        }

        protected void multiplication()
        {
            Console.WriteLine("Multiplication");
            Console.WriteLine("Enter Your First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 * num2;
            Console.WriteLine("Multiplication is :" + sum);
            Console.WriteLine("\n");
        }

        protected void division()
        {
            Console.WriteLine("Division");
            Console.WriteLine("Enter Your First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 / num2;
            Console.WriteLine("Division is :" + sum);
            Console.WriteLine("\n");
        }

        public static void Main(string[] args)
        {
            Arithmetic maths = new Arithmetic();
            maths.addition();
            maths.subraction();
            maths.multiplication();
            maths.division();
        }
    }
}