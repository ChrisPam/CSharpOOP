using System;
using System.Collections.Generic;
using System.Linq;

public class Student : Human
{
    private string facultyNumber;

    public Student(string firstName, string lastName, string facultyNumber)
        : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get { return this.facultyNumber; }
        set
        {
            if (value.Length < 5 || value.Length > 10)
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            this.facultyNumber = value;
        }
    }

    public override string ToString()
    {
        return $"First Name: {this.FirstName}\nLast Name: {this.LastName}\nFaculty number: {this.FacultyNumber}";
    }
}