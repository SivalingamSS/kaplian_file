using System;  
namespace CSharpProgram  
{  
    class Program  
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6] { 5, 8, 9, 25, 0, 7 };
            int[] arr2 = new int[6];
            Console.WriteLine("length of first array: " + arr.Length);
            Array.Sort(arr);
            Console.Write("First array elements: ");
            PrintArray(arr);
            Console.WriteLine("\nIndex position of 25 is " + Array.IndexOf(arr, 25));
            Array.Copy(arr, arr2,5);
            Console.Write("Second array elements: ");
            PrintArray(arr2);
            Array.Reverse(arr);
            Console.Write("\nFirst Array elements in reverse order: ");
            PrintArray(arr);

        }
        static void PrintArray(int[] arr)
        {
            foreach (int elem in arr)
            {
                Console.Write(elem + " ");
            }
        }
    }  
}