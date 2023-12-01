using System;

public static class Maths
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Maths.Add(1, 2);
        //Console.WriteLine(Maths.Add(1, 2));

    }
}
