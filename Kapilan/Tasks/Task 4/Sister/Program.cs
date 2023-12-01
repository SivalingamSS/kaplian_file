public class Example28
{
    public static void Main()
    {
        string str1 = "sister";
        string str2 = "Sister";
        int result = string.Compare(str1, str2);
       //. Console.WriteLine(result);

        if (result < 0 )
        {
            Console.WriteLine("'" +  str1 + "'" + " comes before " + "'" + str2 + "'");
        }
        else if (result == -1 )
        {
            Console.WriteLine("'" + str1 + "'" +  " is the same as " + "'" + str2 + "'");
        }
        else
        {
            Console.WriteLine("'" + str1 + "'" + " comes after " + "'" + str2 + "'");
        }

        result = string.Compare(str1, str2);

        if (result > 0)
        {
            Console.WriteLine("'" + str1 + "'" + " comes before " + "'" + str2 + "'");
        }
        else if (result == -1)
        {
            Console.WriteLine("'" + str1 + "'" + " is the same as " + "'" + str2 + "'");
        }
        else
        {
            Console.WriteLine("'" + str1 + "'" + " comes after " + "'" + str2 + "'");

        }

        result = string.Compare(str1, str2);

        if (result < 0)
        {
            Console.WriteLine("'" + str1 + "'" + " comes before " + "'" + str2 + "'");
        }
        else if (result == -1)
        {
            Console.WriteLine("'" + str1 + "'" + " is the same as " + "'" + str2 + "'");
        }
        else
        {
            Console.WriteLine("'" + str1 + "'" + " comes after " + "'" + str2 + "'");

        }
    }
}