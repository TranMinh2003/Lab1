using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        public class Publication
        {
            public string Title { get; set; }
            public decimal Price { get; set; }
            public int Copies { get; set; }
            public Publication(string title, decimal price, int copies)
            {
                Title = title;
                Price = price;
                Copies = copies;
            }
            public void SellCopy()
            {
                if (Copies > 0)
                {
                    Copies--;
                    Console.WriteLine($"Sold a copy of '{Title}'. Remaining copies: {Copies}");
                }
                else
                {
                    Console.WriteLine($"'{Title}' is out of stock.");
                }
            }
        }
        public class Book : Publication
        {
            public string Author { get; set; }
            public Book(string title, decimal price, int copies, string author)
                : base(title, price, copies)
            {
                Author = author;
            }
            public void OrderCopies(int quantity)
            {
                Copies += quantity;
                Console.WriteLine($"Ordered {quantity} copies of '{Title}'. Total copies: {Copies}");
            }
        }
        public class Magazine : Publication
        {
            public int OrderQty { get; set; }
            public int CurrentIssue { get; set; }

            public Magazine(string title, decimal price, int copies, int orderQty, int currentIssue)
                : base(title, price, copies)
            {
                OrderQty = orderQty;
                CurrentIssue = currentIssue;
            }
            public void AdjustQty(int adjustment)
            {
                Copies += adjustment;
                Console.WriteLine($"Adjusted quantity of '{Title}' by {adjustment}. Total copies: {Copies}");
            }
            public void RecNewIssue()
            {
                CurrentIssue++;
                Console.WriteLine($"Recorded a new issue of '{Title}'. Current issue: {CurrentIssue}");
            }
        }
        static void Main(string[] args)
        {
            Book book = new Book("How psychologgy work", 20.99m, 100, "John Doe");
            book.OrderCopies(50);
            book.SellCopy();

            Magazine magazine = new Magazine("Tech Today", 5.99m, 200, 500, 10);
            magazine.AdjustQty(100);
            magazine.RecNewIssue();
        }
    }
}
