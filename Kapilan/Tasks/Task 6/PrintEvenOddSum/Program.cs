namespace PrintEvenOddSum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter The Starting Number");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Final Number");
            int Last = Convert.ToInt32(Console.ReadLine());

            for (int i = First; i <= Last; i++)
            {
                if(i * Last == 0)
                {
                    Console.WriteLine("Even Numbers Are :");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("jj");
                }
            }
        }
    }
}