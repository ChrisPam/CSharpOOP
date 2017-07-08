using System;

public class Program
{
    public static void Main()
    {
        var firstDate = Console.ReadLine();
        var secondDate = Console.ReadLine();

        var dates = new DateModifier();

        Console.WriteLine(dates.DifferenceOfDays(firstDate, secondDate));
    }
}