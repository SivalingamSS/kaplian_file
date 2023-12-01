using Interface;
using System;
using System.Threading.Channels;

namespace Interface
{
    public interface Iprogram
    {
        public void method();
    }
    public class Program2 
    {
        private Iprogram ips;

        public Program2(Iprogram Ips)
        {
            ips = Ips;
        }

        public void method()
        {
            Console.WriteLine("odd");
        }
    }
    public interface Iprog
    {
        public void method1();
    }
    public class prog : Iprog
    {
        private Iprog ip;

        public prog(Iprog Ip)
        {
                ip= Ip; 
        }
        public void method1()
        {
            Console.WriteLine("even");
        }
    }
}
class mention
{
    public static void Main(string[]args)
    {
    }
}



