using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Book
    {
        // Attributes / States / Variables
        public string Title;
        public string Author;
        public string ISBN;
        public double Price;
        public bool isAvailable;

        public Book()
        {

        }
        public Book(string title, string author, string isbn, double price)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Price = price;
        }
        // Behavior / Method
        public void displayDetails()
        {
            Console.WriteLine("<------------------- Book Details are -------------------> \n");
            Console.WriteLine($"Book Title --> '{Title}'");
            Console.WriteLine($"Book Author --> '{Author}'");
            Console.WriteLine($"Book ISBN --> {ISBN}");
            Console.WriteLine($"Book Price --> $ {Price:F2}");
            Console.WriteLine($"Availability --> " + (isAvailable ? "Available": "Not Available"));
            Console.WriteLine("\t\t------------------------------");
        }
        public void ApplyDisc(double percent)
        {
            if(percent < 0 || percent > 100)
            {
                Console.WriteLine("Invalid Discount Percentage!");
                return;
            }
            double discAmount = (Price * percent) / 100;
            Price -= discAmount;
            Console.WriteLine("Discount Applied --> $"+ Price.ToString("F2"));
        }
    }
}