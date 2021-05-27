using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }
        public List<Employee> Employees { get; set; }


        // Create a public property for holding a list of current employees
        public Company(string EmployeeName, DateTime date)
        {
            Name = EmployeeName;
            CreatedOn = date;
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee newEmployee)
        {
            Employees.Add(newEmployee);
        }

        public void ListEmployee()
        {
            foreach (Employee data in Employees)
            {
                Console.WriteLine($"{data.FirstName} {data.LastName} works for AtlasReign as {data.Title} since {data.StartDate}");
            }
        }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
    }
}

