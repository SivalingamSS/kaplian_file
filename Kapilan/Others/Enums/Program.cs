namespace Enums
{
    internal class Program
    {
        enum Level
        {
            File,
            Edit,
            View
        }
        public static void Main(string[] args)
        {
            Level names = Level.View;
            Console.WriteLine(names);
        }
    }
}