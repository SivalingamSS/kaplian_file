namespace WithoutUsingLoop
{

    class Program
    {
        public static void Main(string[]args)
        {
            int i = 0;
        begin:
            i = i + 1;
            Console.Write(" " + i + " ");

            if (i < 100)
            {
                goto begin;
            }
        }
    }
}