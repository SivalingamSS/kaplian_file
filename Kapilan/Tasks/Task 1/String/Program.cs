namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //common type system (cts)
            string find = Console.ReadLine() ;
            if (find.GetType() == typeof(string))
            {
                Console.WriteLine("It is a string");
            }
            else
            {
                Console.WriteLine("It is a Number");
            }

        }
    }
}