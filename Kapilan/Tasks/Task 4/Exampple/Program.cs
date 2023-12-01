using System;
using System.Text.Json.Serialization;

class Program
{
    static string ReverseWords(string input)
    {
        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length >= 3)
            {
                char[] wordChars = words[i].ToCharArray();
                Array.Reverse(wordChars);
                words[i] = new string(wordChars);
            }
        }
        string result = string.Join(" ", words);

        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string userinput = Console.ReadLine();
    
        string result = ReverseWords(userinput);
        Console.WriteLine("Updated string: " + result);
    }
}