using System;


namespace Classes
{
    public class Employee

    // Employee object/ properties
    {
        public Employee(string EmployeeFirstName, string EmployeeLastName, string EmployeeTitle, DateTime EmployeeStartDate)
        {
            FirstName = EmployeeFirstName;
            LastName = EmployeeLastName;
            Title = EmployeeTitle;
            StartDate = EmployeeStartDate;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }



    }
    // A constructor is special method in a class that is called when a new instance of the class is created. The role of a constructor is to make sure the new object is setup and ready for use immediately after it is created.

}