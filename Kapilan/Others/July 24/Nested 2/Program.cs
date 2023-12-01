namespace Nested_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var m1 = new SortedDictionary<int, String>
            {
                { 3,"Ayalaan"},
                { 2,"Hero"},
                { 1,"rajini"}
            };
            m1.Add(6, "kaki");
            m1.Remove(2);
            m1.ContainsKey(6);  
            //m1.Clear();
            
            foreach (var m2 in m1)
            {
                Console.WriteLine(m2.Key +"." + m2.Value);
            }
        }
    }
}