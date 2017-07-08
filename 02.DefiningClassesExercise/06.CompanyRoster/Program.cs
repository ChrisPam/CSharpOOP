using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var people = new List<Employee>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var name = input[0];
            var salary = decimal.Parse(input[1]);
            var position = input[2];
            var department = input[3];

            Employee person;
            if (input.Length > 5)
            {
                var email = input[4];
                var age = int.Parse(input[5]);
                person = new Employee(name, salary, position, department, email, age);
            }
            else if (input.Length > 4)
            {
                int age;
                bool isAgeField = int.TryParse(input[4], out age);
                if (isAgeField)
                {
                    person = new Employee(name, salary, position, department, age);
                }
                else
                {
                    var email = input[4];
                    person = new Employee(name, salary, position, department, email);
                }

            }
            else
            {
                person = new Employee(name, salary, position, department);
            }
            people.Add(person);
        }

        var depart = people
            .GroupBy(em => em.department)
            .Select(gr => new
            {
                Name = gr.Key,
                AverageSalary = gr.Average(em => em.salary),
                Employees = gr
            })
            .OrderByDescending(gr => gr.AverageSalary)
            .FirstOrDefault();

        Console.WriteLine($"Highest Average Salary: {depart.Name}");
        foreach (var employee in depart.Employees.OrderByDescending(e => e.salary))
        {
            Console.WriteLine(employee.PrintEmployeeInfo());
        }
    }
}

