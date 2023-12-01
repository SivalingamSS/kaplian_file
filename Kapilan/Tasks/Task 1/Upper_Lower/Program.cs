namespace Upper_Lower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "HowDoesTheWoRKGoes";

            string convertedStr = "";

            foreach (char c in str)
            {
                if (char.IsLower(c))
                {
                    convertedStr += char.ToUpper(c);
                }

                else if (char.IsUpper(c))
                {
                    convertedStr += char.ToLower(c);

                }
                else
                {
                    convertedStr += c;

                }
            }

            Console.WriteLine("Original string: " + str);
            Console.WriteLine("Converted string: " + convertedStr);

        }
    }
}