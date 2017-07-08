using System;
using System.Reflection;

public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var family = new Family();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var person = new Person(input[0], int.Parse(input[1]));
            family.AddMember(person);
        }

        var oldestMember = family.GetOldestMember();
        Console.WriteLine($"{oldestMember.name} {oldestMember.age}");

        MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
        MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
        if (oldestMemberMethod == null || addMemberMethod == null)
        {
            throw new Exception();
        }

    }
}