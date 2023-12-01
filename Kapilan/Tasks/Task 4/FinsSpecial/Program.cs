using System;

class CharacterCounter
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int alphabetCount = 0;
        int digitCount = 0;
        int specialCharCount = 0;

        foreach (char c in input)
        {
            if (char.IsLetter(c))
                alphabetCount++;
            else if (char.IsDigit(c))
                digitCount++;
            else
                specialCharCount++;
        }

        Console.WriteLine("Alphabets: " + alphabetCount);
        Console.WriteLine("Digits: " + digitCount);
        Console.WriteLine("Special Characters: " + specialCharCount);
    }
}