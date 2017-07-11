using System;
using System.Collections.Generic;
using System.Linq;

public class Worker : Human
{
    private decimal weekSalary;
    private int workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, int workHoursePerDay)
        :base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursePerDay;
    }

    public int WorkHoursPerDay
    {
        get { return this.workHoursPerDay; }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: {value}");
            }
            this.workHoursPerDay = value;
        }
    }

    
    public decimal WeekSalary
    {
        get { return this.weekSalary; }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: {value}");
            }
            this.weekSalary = value;
        }
    }

    public override string ToString()
    {
        return $"First Name: {this.FirstName}\nLast Name: {this.LastName}\nWeek Salary: {this.weekSalary:f2}\nHours per day: {this.WorkHoursPerDay:f2}\nSalary per hour: {this.weekSalary / (this.workHoursPerDay * 5):f2}";
    }
}