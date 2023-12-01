namespace MultiplicationWhile
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            int length = 10;
            int i = 1;
            Console.WriteLine("Enter The Multiplication Table");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Multiplication Table is : " + num);
            while (i <= length)
            {
                Console.WriteLine($" {i} * {num} = {i * num}");
                i++;
            }
        }
    }
}