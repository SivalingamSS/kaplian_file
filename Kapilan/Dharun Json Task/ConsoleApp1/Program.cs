namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrr = { 1, 2, 3, 4, 5 };
            int arr2 = 6;
            int[] newarray = new int[arrr.Length + 1];
            Array.Copy(arrr, newarray, arrr.Length);
            newarray[newarray.Length - 1] = arr2;
            foreach (int i in newarray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("----------------------------------------------------");

            string[] colorsArray = { "Red", "Blue" };
            var data = colorsArray.ToList();
            data.Add("Green");
            var convert = data.ToArray();
            foreach (var item in convert)
            {
                Console.WriteLine(item);
            }
        }
    }
}