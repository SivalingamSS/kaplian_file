using System;
public class Exercise20
{
    public static void Main()
    {
        var startDateA = new DateTime(2023, 5, 1);
        var endDateA = new DateTime(2023, 5, 10);
        var startDateB = new DateTime(2023, 5, 11);
        var endDateB = new DateTime(2023, 5, 20);
        if (startDateA < endDateA && endDateA < startDateB && endDateA < endDateB )
        {
            Console.WriteLine("Overlapping");
        }
        else
        {
            Console.WriteLine("NotOverlapping");
        }
    }
}
