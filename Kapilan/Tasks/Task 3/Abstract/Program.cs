namespace Abstract
{
    abstract class School
    {
        public abstract void Tree();
        public void Table()
        {
            Console.WriteLine("Lesson");
        }
    }
    class Animal : School
    {
        public override void Tree()
        {
            Console.WriteLine("Teaching");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Animal sch = new Animal();
            sch.Tree();
            sch.Table();
        }
    }.
}


