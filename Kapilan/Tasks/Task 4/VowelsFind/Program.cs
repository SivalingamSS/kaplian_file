using System;

class Program
{
    static int CountVowels(string input)
    {
        int count = 0;
        string vowels = "aeiouAEIOU";

        foreach (char ch in input)
        {
            if (vowels.Contains(ch))
            {
                count++;
            }
        }

        return count;
    }

    static int CountConsonants(string input)
    {
        int count = 0;
        string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";

        foreach (char ch in input)
        {
            if (consonants.Contains(ch))
            {
                count++;
            }
        }

        return count;
    }
    static void Main()
    {
         Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int vowelCount = CountVowels(input);
        int consonantCount = CountConsonants(input);

        Console.WriteLine("Number of vowels: " + vowelCount);
        Console.WriteLine("Number of consonants: " + consonantCount);
    }

}
