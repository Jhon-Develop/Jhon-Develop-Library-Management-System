using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_management.Models
{
    public class Library
    {
        public int Id { get; set; }
        public required List<Book> Books { get; set; }

        public List<Book> SearchGender(string gender)
        {
            var booksByGender = Books.Where(book => book.Gender.Equals(gender, StringComparison.OrdinalIgnoreCase)).ToList();

            return booksByGender.Count != 0 ? booksByGender : new List<Book>();
        }

        public List<Book> SearchAuthor(string author)
        {
            var booksByAuthor = Books.Where(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();

            return booksByAuthor.Any() ? booksByAuthor : new List<Book>();
        }

        public List<Book> SearchYearRange(int startYear, int endYear)
        {
            var booksInYearRange = Books.Where(book => book.PublishedOn >= startYear && book.PublishedOn <= endYear).ToList();

            return booksInYearRange.Any() ? booksInYearRange : new List<Book>();
        }

        public void AddBook(Book book)
        {
            string newBookTitle = Setting.InputString("Enter the title of the new book: ");
            string newBookAuthor = Setting.InputString("Enter the author of the new book: ");
            int newBookPublishedOn = Setting.InputInt("Enter the published on date of the new book: ");
            string newBookIsbn = Setting.InputString("Enter the ISBN of the new book: ");
            string newBookGender = Setting.InputString("Enter the gender of the new book: ");
            double newBookPrice = Setting.InputDouble("Enter the price of the new book: ");
            double newBookDiscountRate = Setting.InputDouble("Enter the discount rate of the new book: ");
            
            Book newBook = new(Id, newBookTitle,newBookPublishedOn, newBookAuthor, newBookIsbn, newBookGender, newBookPrice, newBookDiscountRate);
            
            Books.Add(newBook);
            Console.WriteLine("");
            Console.WriteLine("Book added successfully!");
            Console.WriteLine("");

            Setting.FinishOption();
        }
    }
}

/*
        public string Author { get; set; } = author;
        public string Isbn { get; set; } = isbn;
        public string Gender { get; set; } = gender;
        public double Price { get; set; } = price;
        public double DiscountRate { get; set; } = discountRate;
*/