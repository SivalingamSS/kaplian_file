using System;

namespace MyApplication
{
    abstract class program
    {
        public abstract void method();
        public void Method()
        {
            Console.WriteLine("Game");
        }
    }
    class aim : program
    {
        public override void method()
        {
            Console.WriteLine("the bous");
        }
    }
    class final : aim
    {
        public static void main(string[] args)
        {
            final cal = new final();
            cal.method();
            cal.Method();
        }
    }
}

