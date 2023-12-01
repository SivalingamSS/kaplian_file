using System;

public class CountCharacter
{
    public static void Main()
    {
        String string1 = "The besta of both worlds";
        int count = 0;  
        for (int i = 0; i < string1.Length; i++)
        {
            if (string1[i] == 'a')
            {
                count++;
            }
        }
        Console.WriteLine("Total number of characters in a string: " + count);
    }
}