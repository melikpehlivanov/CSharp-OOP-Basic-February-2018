using System;
using System.Text;

public class Worker : Human
{
    private const int workDaysPerWeek = 5;

    private decimal weekSalary;
    private decimal workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekSalary
    {
        get => this.weekSalary;
        protected set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.weekSalary = value;
        }
    }

    public decimal WorkHoursPerDay
    {
        get => this.workHoursPerDay;
        protected set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            this.workHoursPerDay = value;
        }
    }

    private decimal SalaryPerHour()
    {
        return this.WeekSalary / workDaysPerWeek / this.workHoursPerDay;
    }

    public override string ToString()
    {
        var sb = new StringBuilder()
            .AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Week Salary: {this.WeekSalary:f2}")
            .AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}")
            .AppendLine($"Salary per hour: {SalaryPerHour():f2}");

        return sb.ToString();
    }
}

