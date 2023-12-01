namespace NestedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> m1 = new List<String>();
            m1.Add("raj");
            m1.Add("kumar");
            m1.Add("dinesh");
            m1.Remove("kumar");
            m1.Clear();

            foreach (var kvp in m1)
            {
                Console.WriteLine(kvp);
            }

        }
    }
}