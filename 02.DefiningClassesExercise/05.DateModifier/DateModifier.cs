using System;
using System.Globalization;
using System.Linq;

public class DateModifier
{
    public string firstDate;
    public string secondDate;

    public int DifferenceOfDays(string firstDate, string secondDate)
    {
        DateTime firstDateTime = DateTime.Parse(firstDate);
        DateTime secondDateTime = DateTime.Parse(secondDate);


        var totalDaysDifference = Math.Abs((int)(firstDateTime - secondDateTime).TotalDays);

        return totalDaysDifference;
    }
}