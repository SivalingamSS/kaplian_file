namespace FileReaderrrr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\visualapp\Documents\Example.txt";
            string read = File.ReadAllText(filepath);
            Console.WriteLine(read);
        }
    }
}
