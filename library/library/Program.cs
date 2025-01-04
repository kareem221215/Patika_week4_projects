using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book DefaultBook = new Book();
            Console.WriteLine($"Default book: {DefaultBook.Title}, Registration {DefaultBook.RegistrationDate.ToString("dd/MM/yyyy")}");

            Book book = new Book("The Catcher in the Rye", "J.D.", "Salinger", 277 , " Little, Brown and Company");
            Console.WriteLine($"Book: {book.Title}, Author: {book.writerName} {book.writerSurname}, Pages: {book.numberOfPages}, Publisher: {book.publisher}, Registered: {book.RegistrationDate.ToString("dd/MM/yyyy")}");

            Book book2 = new Book("1984", "George", "Orwell", 328, "Secker & Warburg");
            Console.WriteLine($"Book: {book2.Title}, Author: {book2.writerName} {book2.writerSurname}, Pages: {book2.numberOfPages}, Publisher: {book2.publisher}, Registered: {book2.RegistrationDate.ToString("dd/MM/yyyy")}");

            Book book3 = new Book("To Kill a Mockingbird", "Harper", "Lee", 281, "J.B. Lippincott & Co.");
            Console.WriteLine($"Book: {book3.Title}, Author: {book3.writerName} {book3.writerSurname}, Pages: {book3.numberOfPages}, Publisher: {book3.publisher}, Registered: {book3.RegistrationDate.ToString("dd/MM/yyyy")}");

            Book book4 = new Book("The Great Gatsby", "F. Scott", " Fitzgerald", 180, "  Charles Scribner's Sons");
            Console.WriteLine($"Book: {book4.Title}, Author: {book4.writerName} {book4.writerSurname}, Pages: {book4.numberOfPages}, Publisher: {book4.publisher}, Registered: {book4.RegistrationDate.ToString("dd/MM/yyyy")}");

            Book book5 = new Book("Pride and Prejudice", "Jane", "Austen", 279, " T. Egerton");
            Console.WriteLine($"Book: {book5.Title}, Author: {book5.writerName} {book5.writerSurname}, Pages: {book5.numberOfPages}, Publisher: {book5.publisher}, Registered: {book5.RegistrationDate.ToString("dd/MM/yyyy")}");
        }
        public class Book
        {
            public string Title { get; set; }
            public string writerName { get; set; }
            public string writerSurname { get; set; }
            public int numberOfPages { get; set; }
            public string publisher { get; set; }
            public DateTime RegistrationDate { get; set; }
            public Book()
            {
                Title = "unknown";
                writerName = "unknown";
                writerSurname = "unknown";
                numberOfPages = 0;
                publisher = "unknown";
                RegistrationDate = DateTime.Now;
            }

            public Book(string title, string writerName, string writerSurname, int numberOfPages, string publisher)
            {
                this.Title = title;
                this.writerName = writerName;
                this.writerSurname = writerSurname;
                this.numberOfPages = numberOfPages;
                this.publisher = publisher;
                RegistrationDate = DateTime.Now;
                
            }
        }

    }
}
