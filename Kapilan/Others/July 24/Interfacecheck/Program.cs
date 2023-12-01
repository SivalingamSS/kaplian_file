
namespace Interfacecheck
{
    interface Iinter
    {
        public void m1();
        public void m2();
    }
    class Program : Iinter
    {
        public void m1()
        {
            Console.WriteLine("Its me");
        }
        public void m2()
        {
            Console.WriteLine("Rocky");
        }
    }
    
    class Program1 : Program
    { 
        static void Main(string[] args)
        {
            Program1 cal = new Program1();
            cal.m1();
            cal.m2();
        }
    }
}