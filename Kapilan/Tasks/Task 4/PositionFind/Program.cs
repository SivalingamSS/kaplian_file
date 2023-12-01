namespace PositionFind
{
   class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; true; i++)
            {
                Console.WriteLine("Enter Your Position");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        {
                            Console.WriteLine("The");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("quick");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("brown");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("fox");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("jumps");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("over");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("the");
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("lazy");
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("dog");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Sorry There Is No Data");
                            break;
                        }
                }
            }
        }
    }
}
/*        {
            string str1 = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine("Original string: " + str1);
            Console.WriteLine("Position of the word 'fox' in the said string: " + test(str1, "fox"));
            Console.WriteLine("Position of the word 'The' in the said string: " + test(str1, "The"));
            Console.WriteLine("Position of the word 'lazy' in the said string: " + test(str1, "lazy"));
        }
        public static int test(string text, string word)
        {
            return Array.IndexOf(text.Split(' '), word) + 1;
        }
    }*/


