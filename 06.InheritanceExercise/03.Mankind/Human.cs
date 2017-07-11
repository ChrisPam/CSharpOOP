using System;
using System.Collections.Generic;
using System.Linq;

public class Human
{
    private string firstName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string LastName
    {
        get { return this.lastName; }
        set
        {
            if (value.First().ToString().ToUpper() != value.First().ToString())
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {value}");
            }
            if (value.Length <= 2)
            {
                throw new ArgumentException($"Expected length at least 4 symbols! Argument: {value}");
            }
            this.lastName = value;
        }
    }

    
    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (value.First().ToString().ToUpper() != value.First().ToString())
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {value}");
            }
            if (value.Length <= 3)
            {
                throw new ArgumentException($"Expected length at least 4 symbols! Argument: {value}");
            }
            this.firstName = value;
        }
    }

    
}