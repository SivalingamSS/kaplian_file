using Constructor;
namespace Constructor
{
    class Program1
    {
       private Interface2 Interface2;
        public  Program1(Interface2 inter)
        {
            Interface2 = inter;
        }
        public void odd()
        {
            Interface2.even();

        }

        class Program2 : Interface2
        {
            public void even()
            {
                Console.WriteLine("BaBaBlackSheep");
            }
        }
        class intre
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("heo");
            }
        }
    }
}