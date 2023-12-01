using System;
public class Exercise5
{
    public static void Main()
    {
        Console.Write("Input the string : ");
        string str = Console.ReadLine();

       int i = 0;
       int j = 1;

        while (i <= str.Length-1)
        {
            if(str[i] == ' ' || str[i] == '\n' || str[i] == '\t')
            {
                j++;
            }

            i++;
        }
        Console.Write($"Total number of words in the string is : {j}\n");
    }
}
