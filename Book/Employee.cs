using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Employee
    {
        public int EmployeeID;
        public string Name;
        public string Department;
        public double Salary;

        public Employee()
        {

        }
        public Employee(int id , string name, string department , double salary)
        {
            EmployeeID = id;
            Name = name;
            Department = department;
            Salary = salary;
        }
        public void IncreaseSalary(double amount)
        {
            if(amount > 0)
            {
                Salary += amount;
                Console.WriteLine($"Salary increased by ${amount:F2}. New Salary --> ${Salary:F2}");
            }
            else
            {
                Console.WriteLine("Invalid Salary Increase Amount!");
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"<------------------- Employess Details -------------------> \n");
            Console.WriteLine($"Employee ID --> {EmployeeID}");
            Console.WriteLine($"Name --> {Name}");
            Console.WriteLine($"Department --> {Department}");
            Console.WriteLine($"Salary --> ${Salary:F2}");
        }
    }
}
