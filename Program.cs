using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Company AtlasReign = new Company("AtlasReign", DateTime.Now);
            // Create an instance of a company. Name it whatever you like.


            Employee Autumn = new Employee("Autumn", "Fotopoulos", "Manager", DateTime.Now);

            Employee Asia = new Employee("Asia", "Nitz", "associate", DateTime.Now);

            Employee Kristine = new Employee("Kristine", "Wade", "associate", DateTime.Now);
            // Create three employees

            // Assign the employees to the company
            AtlasReign.AddEmployee(Autumn);
            AtlasReign.AddEmployee(Asia);
            AtlasReign.AddEmployee(Kristine);
            AtlasReign.ListEmployee();
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}
