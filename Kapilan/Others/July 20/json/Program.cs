namespace json
{
         class Program
    {
        static void Main(string[] args)
        {
            string a = @"C:\Kapilan\json\tsconfig1.json";
            string f = File.ReadAllText(a); 
            Console.WriteLine(f);
        }
    }
}