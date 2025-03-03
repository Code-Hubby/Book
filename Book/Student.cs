using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Student
    {
        public string regNo;
        public string name;
        public double gpa;

        public Student(string reg,string na,double g)
        {
            regNo = reg;
            name = na;
            gpa = g;
        }
        public Student()
        {
            regNo = "Nill";
            name = "Unknown";
            gpa = 2.0;
        }
        public void Display()
        {
            Console.WriteLine("\t\t\n\n|_-_-_-_-_-_-_-_-_-_-_ Student Management System _-_-_-_-_-_-_-_-_-_-_|");
            Console.Write($"Reg No. --> {regNo}\n");
            Console.Write($"Name. --> {name}\n");
            Console.Write($"GPA. --> {gpa:F2} \n");
        }
    }
}
