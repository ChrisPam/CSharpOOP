using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var people = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var person = new Person(input[0], int.Parse(input[1]));

            if(person.age > 30)
            {
                people.Add(person);
            }
        }

        foreach (var person in people.OrderBy(x => x.name))
        {
            Console.WriteLine($"{person.name} - {person.age}");
        }
    }
}