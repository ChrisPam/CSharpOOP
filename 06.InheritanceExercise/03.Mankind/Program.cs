using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main()
    {
        var people = new List<Human>();

        var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        var studentFirstName = input[0];
        var studentLastName = input[1];
        var studentfacultyNumber = input[2];
        try
        {
            var student = new Student(studentFirstName, studentLastName, studentfacultyNumber);
            people.Add(student);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }

        input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        var workerFirstName = input[0];
        var workerLastName = input[1];
        var weekSalary = decimal.Parse(input[2]);
        var hoursPerDay = int.Parse(input[3]);
        try
        {
            var worker = new Worker(workerFirstName, workerLastName, weekSalary, hoursPerDay);
            people.Add(worker);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }


        foreach (var human in people)
        {
            Console.WriteLine($"{human}\n");
        }
    }
}