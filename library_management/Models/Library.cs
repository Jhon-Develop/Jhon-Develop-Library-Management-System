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

        public void PrintBooks(List<Book> books)
        {
            string bookLineSeparator = new('-', Console.WindowWidth);
            if (books.Any())
            {
                Console.WriteLine("Books found:");
                Console.WriteLine(bookLineSeparator);
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Title, -40} | {book.Isbn, -20} | {book.Author, -25} | {book.Gender, -15} | {book.PublishedOn, -15} | {book.Price, -10} | {book.DiscountRate, -10}");
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("No books found matching the criteria.");
            }
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
        public void RemoveBook()
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

        public void SearchBooks(string gender, string author, string title, int publishedOn, double price, int discountRate)
        {
            var filteredBooks = Books.AsEnumerable();

            if (!string.IsNullOrEmpty(gender))
            {
                filteredBooks = filteredBooks.Where(book => book.Gender.Equals(gender, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(author))
            {
                filteredBooks = filteredBooks.Where(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(title))
            {
                filteredBooks = filteredBooks.Where(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            }

            if (publishedOn > 0)
            {
                filteredBooks = filteredBooks.Where(book => book.PublishedOn == publishedOn);
            }

            if (price > 0)
            {
                filteredBooks = filteredBooks.Where(book => book.Price >= price);
            }

            if (discountRate > 0)
            {
                filteredBooks = filteredBooks.Where(book => book.DiscountRate >= discountRate);
            }

            var booksList = filteredBooks.ToList();

            if (booksList.Any())
            {
                Console.WriteLine("Books found:");
                Console.WriteLine("-------------");
                foreach (var book in booksList)
                {
                    Console.WriteLine($"{book.Title,-40} | {book.Isbn,-20} | {book.Author,-25} | {book.Gender,-15} | {book.PublishedOn,-15} | {book.Price,-10} | {book.DiscountRate,-10}");
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("No books found matching the criteria.");
            }
        }
        public void AdvancedSearch(Library library)
        {
            string gender = Setting.InputString("Enter gender (or leave empty): ");
            string author = Setting.InputString("Enter author (or leave empty): ");
            string title = Setting.InputString("Enter title (or leave empty): ");
            int publishedOn = Setting.InputInt("Enter published year (or 0 to skip): ");
            double price = Setting.InputDouble("Enter minimum price (or 0 to skip): ");
            int discountRate = Setting.InputInt("Enter minimum discount rate (or 0 to skip): ");

            library.SearchBooks(gender, author, title, publishedOn, price, discountRate);
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