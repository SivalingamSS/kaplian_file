namespace Logical_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12, b = 27;
            {
                Console.WriteLine(a<b && a>b);
                Console.WriteLine(a<b || a>b);
                Console.WriteLine(!(a<b && a>b));

            }
        }
    }
}