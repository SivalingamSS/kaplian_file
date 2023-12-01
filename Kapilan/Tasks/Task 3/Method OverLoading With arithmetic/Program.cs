namespace Day3_Tasks
{
    internal class Program
    {
        public void Arithmetic(int a)
        {
            Console.WriteLine("Addition:"+ (a+13));
        }
        public void Arithmetic(int b,int c )
        {
            Console.WriteLine("Subraction:"+ (b-c));
        }

        public void Arithmetic(int d,int e,int f)
        {
            Console.WriteLine("Multiplication:" + (d*e*f));
        }

        public void Arithmetic(int g,int h,int i,int j)
        {
            Console.WriteLine("Divition:" + (g/h/i/j));
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1. Arithmetic(27);
            p1.Arithmetic(18,3);
            p1.Arithmetic(5,4,4);
            p1.Arithmetic(16,8,4,2);
        }
    }
}