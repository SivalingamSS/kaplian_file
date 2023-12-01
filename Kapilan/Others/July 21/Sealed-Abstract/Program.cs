namespace Sealed_Abstract
{
    sealed class Program
    {
        abstract void method();
        public void method()
        {
            Console.WriteLine("uh");
        }
    }
    sealed class program
    {
        public override method()
        {
            Console.WriteLine("6t6tf");
        }
    
      public   static void Main(string[] args)
        {
            Program cal = new Program();
            cal.method();
            cal.method();
        }
    }
}