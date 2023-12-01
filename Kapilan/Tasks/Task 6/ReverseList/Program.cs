using System.Collections.Generic;

namespace ReverseList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            list.Reverse();
            Console.WriteLine(String.Join(',', list));
        }
    }
}