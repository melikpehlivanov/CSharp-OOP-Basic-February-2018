namespace _06.Company_Roster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfEmployees = int.Parse(Console.ReadLine());

            var employees = new List<Employee>();
            for (int index = 0; index < numberOfEmployees; index++)
            {
                var employeeInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = employeeInfo[0];
                var salary = decimal.Parse(employeeInfo[1]);
                var position = employeeInfo[2];
                var department = employeeInfo[3];
                var employee = new Employee(name, salary, position, department);

                if (employeeInfo.Length > 4)
                {
                    var ageOrEmail = employeeInfo[4];
                    if (ageOrEmail.Contains("@"))
                    {
                        employee.Email = ageOrEmail;
                    }
                    else
                    {
                        employee.Age = int.Parse(ageOrEmail);
                    }
                }

                if (employeeInfo.Length > 5)
                {
                    employee.Age = int.Parse(employeeInfo[5]);
                }

                employees.Add(employee);
            }

            var result = employees
                .GroupBy(e => e.Department)
                .Select(d => new
                {
                    Department = d.Key,
                    AverageSalary = d.Average(e => e.Salary),
                    Employees = d.OrderByDescending(emp => emp.Salary).ToList()
                })
                .OrderByDescending(d => d.AverageSalary)
                .FirstOrDefault();


            if (result != null)
            {
                Console.WriteLine($"Highest Average Salary: {result.Department}");

                foreach (var employee in result.Employees)
                {
                    Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
                }
            }
        }
    }
}
