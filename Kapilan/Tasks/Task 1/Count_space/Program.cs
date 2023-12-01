using System;
namespace spacecount
{
    public class funcexer4
    {

        static void Main(string[] args)
        {
            int space = 0;
            string str1 = "Welcome your world";
            char str = ' ';

            foreach(char s in str1)
            {
                if(s == str)
                {
                    space++;
                }
            }
          
            Console.WriteLine(space);
        }

       

    }

}