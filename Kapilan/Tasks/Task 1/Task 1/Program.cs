namespace Task_1
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            int length = 10;
            int i;
            Console.WriteLine("Enter The Multiplication Number");
            int num =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number = " + num);
            for ( i = 1; i <= length; i++)
            {
                Console.WriteLine($"{i} * {num} = {i * num}");
            }

        }
    }
}