using System;
using System.Drawing;

namespace MyApplication
{
    internal class Program
    {
        public void Methods() {
            int[] num = { 10, 20, 230, 34, 56, 10, 12, 34, 56, 56 };
            int[] u = num.Distinct().ToArray();
            foreach (int i in u)
            {
                Console.WriteLine(i);

            }
            {
                Console.WriteLine("___________________________");
            }

        }
        public void Split()
        {
            string a = "Jackfruit";
            char[] b = a.ToCharArray();
            foreach (char c in b)
            {
                Console.WriteLine(c);
            }
            {
                Console.WriteLine("___________________________");
            }

        }
        public void Reversee()
        {
            String a = ("Visual App Foundary");
            Char[] b = a.ToCharArray();
            Array.Reverse(b);
            foreach (char h in b)
            {
                string s = new string(Char.ToString(h));
                Console.WriteLine(s);
            }
        }
        public void Duplicat()
        {
            string a = "Jacaaaakfruit";
            char[] b = a.ToCharArray();
           string  mai= new (b.Distinct().ToArray());
            Console.WriteLine(mai);
            {
                Console.WriteLine("___________________________");
            }

        }
        public static void Main(string[] args)

        {
            Program dup =new  Program();
            dup.Methods();
            dup.Split();
            dup.Reversee();
            dup.Duplicat();
      
        }
    }
 }
    
