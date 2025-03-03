using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_ Library Management System _-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
            Book booknew = new Book();      // Book() --> Constructor
            
            Book book1 = new Book();
            book1.Title = "Sad Stories";
            book1.Author = "by Ab Ab Gohar";
            book1.ISBN = "192803";
            book1.Price = 20.0;
            book1.isAvailable = true;
            book1.displayDetails();
            Console.WriteLine("\n\t\t--- Applying 10% Discount ---");
            book1.ApplyDisc(10);
            Console.WriteLine("\n\t\t--- Updated Book Info ---");
            book1.displayDetails();

            Book book2 = new Book();
            book2.Title = "Saad Stories";
            book2.Author = "by Saadi"; 
            book2.ISBN = "281107";
            book2.Price = 25.0;
            book2.isAvailable = true;
            book2.displayDetails();
            Console.WriteLine("\n\t\t--- Applying 5% Discount ---");
            book2.ApplyDisc(5);
            Console.WriteLine("\n\t\t--- Updated Book Info ---");
            book2.displayDetails();

            Book book3 = new Book();
            book3.Title = "Dastan e Ali";
            book3.Author = "by Ali Udas";
            book3.ISBN = "040506";
            book3.Price = 30.0;
            book3.isAvailable = true;
            book3.displayDetails();
            Console.WriteLine("\n\t\t--- Applying 15% Discount ---");
            book3.ApplyDisc(15);
            Console.WriteLine("\n\t\t--- Updated Book Info ---");
            book3.displayDetails();
           
            Console.WriteLine("\t-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_ Employee Management System _-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
            Employee employee1 = new Employee();
            employee1.EmployeeID = 101;
            employee1.Name = "Muhammad AB Gohar";
            employee1.Department = "Software Engineer";
            employee1.Salary = 50000;
            employee1.DisplayInfo();

            Employee employee2 = new Employee();
            employee2.EmployeeID = 102;
            employee2.Name = "M. Saad Khalid";
            employee2.Department = "Information Technology";
            employee2.Salary = 45000;
            employee2.DisplayInfo();

            Employee employee3 = new Employee();
            employee3.EmployeeID = 103;
            employee3.Name = "M. Ali Anwer";
            employee3.Department = "Cyber Security";
            employee3.Salary = 48000;
            employee3.DisplayInfo();

            Student Std1 = new Student();
            Std1.Display();

            Student Std2 = new Student();
            Std2.regNo = "NTU_1174"; 
            Std2.name = "Muhammad Abdullah Gohar"; 
            Std2.gpa = 3.5; 
            Std2.Display();
            Console.ReadLine();
        }
    }
}
