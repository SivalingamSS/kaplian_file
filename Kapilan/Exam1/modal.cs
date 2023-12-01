namespace Exam1
{
    public class Batter
    {
        public string id { get; set; }
        public string type { get; set; }
    }
    public class Batters
    {
        public List<Batter> batter { get; set; }
    }
    public class Root
    {
        public Batters batters { get; set; }
    }
    public class Topping
    {
        public string id { get; set; }
        public string type { get; set; }
    }
}


