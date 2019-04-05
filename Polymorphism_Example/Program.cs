using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Example
{

    public class PartTimeEmp :Employee
    {
        public override void PrintFullName()
        {
            FirstName = "HarshadPartTime";
            LastName = "PanditPartTime";
            Console.WriteLine($"The Partime employee name is:{FirstName} {LastName}");
        }
    }
    public class FullTimeEmp:Employee
    {
        public override void PrintFullName()
        {
            FirstName = "HarshadFulltime";
            LastName = "PanditFullTime";
            Console.WriteLine($"The FullTime employee name is:{FirstName} {LastName}");
        }
    }


    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual void PrintFullName()
        {
            FirstName = "HarshadNewEmp";
            LastName = "PanditNewEmp";
            Console.WriteLine($"The new employee name is:{FirstName} {LastName}");
        }
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3]; 
            employees[0] = new Employee();
            employees[1] = new PartTimeEmp();
            employees[2] = new FullTimeEmp();

            foreach (var emp in employees)
            {
                emp.PrintFullName();
            }
            Console.ReadLine();


        }
    }
}
