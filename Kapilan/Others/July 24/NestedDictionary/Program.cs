namespace NestedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> m1 = new SortedDictionary<int, String>();
            m1.Add(3, "raj");
            m1.Add(2, "kumar");
            m1.Add(1, "dinesh");
            m1.Remove(3);
            m1.ContainsKey(2);
           // m1.Clear();

            foreach (var kvp in m1)
            {
                Console.WriteLine(kvp.Key+"."+kvp.Value);
            }

        }
    }
}