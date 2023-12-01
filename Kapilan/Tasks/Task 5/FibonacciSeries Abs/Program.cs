namespace abs
{
    public abstract class Program
    {
        public abstract void Fibonacci();
        public void Name()
        {
            Console.WriteLine("Finished....");
        }

    }

    public class Program1 : Program
    {
        public override void Fibonacci()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the number of elements:");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");    
            for (i = 2; i < number; ++i)    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
        static void Main(string[] args)
        {
            Program1 c = new Program1();
            c.Fibonacci();
        }
    }
}