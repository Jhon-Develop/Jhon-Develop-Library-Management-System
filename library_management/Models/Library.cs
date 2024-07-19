using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_management.Models
{
    public class Library
    {
        public int Id { get; set; }
        public required List<Book> Books { get; set; } = new List<Book>();

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

        public void AddBook()
        {
            string newBookTitle = Setting.InputString("Enter the title of the new book: ");
            string newBookAuthor = Setting.InputString("Enter the author of the new book: ");
            int newBookPublishedOn = Setting.InputInt("Enter the published on date of the new book: ");
            string newBookIsbn = Setting.InputString("Enter the ISBN of the new book: ");
            string newBookGender = Setting.InputString("Enter the gender of the new book: ");
            double newBookPrice = Setting.InputDouble("Enter the price of the new book: ");
            double newBookDiscountRate = Setting.InputDouble("Enter the discount rate of the new book: ");

            Book newBook = new(Id, newBookTitle, newBookPublishedOn, newBookAuthor, newBookIsbn, newBookGender, newBookPrice, newBookDiscountRate);

            Books.Add(newBook);
            Console.WriteLine("");
            Console.WriteLine("Book added successfully!");
            Console.WriteLine("");

            Setting.FinishOption();
        }
        public void RemoveBook(int bookId)
        {
            string bookTitle = Setting.InputString("Enter the title of the book to remove: ");

            Book? bookToRemove = Books.FirstOrDefault(book => book.Title.Equals(bookTitle, StringComparison.OrdinalIgnoreCase));

            if (bookToRemove != null)
            {
                Books.Remove(bookToRemove);
                Console.WriteLine("");
                Console.WriteLine("Book removed successfully!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Book not found!");
                Console.WriteLine("");
            }

            Setting.FinishOption();
        }

        public void SearhBooks(string gender, string author, string title, int publishedOn, double price, int discountRate)
        {
            var booksByGender = Books.Where(book => book.Gender.Equals(gender, StringComparison.OrdinalIgnoreCase)).ToList();
            var booksByAuthor = Books.Where(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
            var booksByTitle = Books.Where(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase)).ToList();
            var booksInYearRange = Books.Where(book => book.PublishedOn >= publishedOn && book.PublishedOn <= publishedOn).ToList();
            var booksByPrice = Books.Where(book => book.Price >= price).ToList();
            var booksByDiscountRate = Books.Where(book => book.DiscountRate >= discountRate).ToList();

            Console.WriteLine("Books found:");
            Console.WriteLine("-------------");

            if (booksByGender.Any())
            {
                Console.WriteLine("Books by gender:");
                Console.WriteLine("----------------");
                foreach (var book in booksByGender)
                {
                    Console.WriteLine($"{book.Title} - {book.Author} - {book.PublishedOn} - {book.Price} - {book.DiscountRate}");
                }
                Console.WriteLine("");
            }

            if (booksByAuthor.Any())
            {
                Console.WriteLine("Books by author:");
                Console.WriteLine("----------------");
                foreach (var book in booksByAuthor)
                {
                    Console.WriteLine($"{book.Title} - {book.Author} - {book.PublishedOn} - {book.Price} - {book.DiscountRate}");
                }
                Console.WriteLine("");
            }

            if (booksByTitle.Any())
            {
                Console.WriteLine("Books by title:");
                Console.WriteLine("----------------");
                foreach (var book in booksByTitle)
                {
                    Console.WriteLine($"{book.Title} - {book.Author} - {book.PublishedOn} - {book.Price} - {book.DiscountRate}");
                }
                Console.WriteLine("");
            }

            if (booksInYearRange.Any())
            {
                Console.WriteLine("Books in year range:");
                Console.WriteLine("--------------------");
                foreach (var book in booksInYearRange)
                {
                    Console.WriteLine($"{book.Title} - {book.Author} - {book.PublishedOn} - {book.Price} - {book.DiscountRate}");
                }
                Console.WriteLine("");
            }

            if (booksByPrice.Any())
            {
                Console.WriteLine("Books by price:");
                Console.WriteLine("---------------");
                foreach (var book in booksByPrice)
                {
                    Console.WriteLine($"{book.Title} - {book.Author} - {book.PublishedOn} - {book.Price} - {book.DiscountRate}");
                }
                Console.WriteLine("");
            }

            if (booksByDiscountRate.Any())
            {
                Console.WriteLine("Books by discount rate:");
                Console.WriteLine("-----------------------");
                foreach (var book in booksByDiscountRate)
                {
                    Console.WriteLine($"{book.Title} - {book.Author} - {book.PublishedOn} - {book.Price} - {book.DiscountRate}");
                }
                Console.WriteLine("");
            }
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