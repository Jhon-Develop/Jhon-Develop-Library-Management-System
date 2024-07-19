using library_management.Models;

namespace library_management;

public class Program
{
    public static void Main(string[] args)
    {
                var library = new Library
        {
            Id = 1,
            Books = new List<Book>
            {
                new Book(1, "The Great Gatsby", 1925, "F. Scott Fitzgerald", "1234567890123", "Fiction", 10.99, 5),
                new Book(2, "To Kill a Mockingbird", 1960, "Harper Lee", "1234567890124", "Fiction", 7.99, 10),
                new Book(3, "1984", 1949, "George Orwell", "1234567890125", "Dystopian", 8.99, 15),
                new Book(4, "Pride and Prejudice", 1813, "Jane Austen", "1234567890126", "Romance", 9.99, 0),
                new Book(5, "The Catcher in the Rye", 1951, "J.D. Salinger", "1234567890127", "Fiction", 6.99, 20),
                new Book(6, "The Hobbit", 1937, "J.R.R. Tolkien", "1234567890128", "Fantasy", 8.99, 10),
                new Book(7, "Fahrenheit 451", 1953, "Ray Bradbury", "1234567890129", "Dystopian", 7.49, 5),
                new Book(8, "Jane Eyre", 1847, "Charlotte Brontë", "1234567890130", "Romance", 8.49, 15),
                new Book(9, "Moby-Dick", 1851, "Herman Melville", "1234567890131", "Adventure", 9.99, 10),
                new Book(10, "The Odyssey", -700, "Homer", "1234567890132", "Epic", 10.99, 0),
                new Book(11, "War and Peace", 1869, "Leo Tolstoy", "1234567890133", "Historical", 12.99, 20),
                new Book(12, "The Iliad", -750, "Homer", "1234567890134", "Epic", 11.99, 5),
                new Book(13, "Brave New World", 1932, "Aldous Huxley", "1234567890135", "Dystopian", 6.99, 10),
                new Book(14, "Crime and Punishment", 1866, "Fyodor Dostoevsky", "1234567890136", "Psychological", 9.99, 15),
                new Book(15, "Wuthering Heights", 1847, "Emily Brontë", "1234567890137", "Romance", 7.99, 5),
                new Book(16, "The Divine Comedy", 1320, "Dante Alighieri", "1234567890138", "Epic", 13.99, 10),
                new Book(17, "The Brothers Karamazov", 1880, "Fyodor Dostoevsky", "1234567890139", "Philosophical", 10.99, 20),
                new Book(18, "Great Expectations", 1861, "Charles Dickens", "1234567890140", "Fiction", 8.49, 5),
                new Book(19, "The Grapes of Wrath", 1939, "John Steinbeck", "1234567890141", "Fiction", 9.99, 10),
                new Book(20, "Les Misérables", 1862, "Victor Hugo", "1234567890142", "Historical", 11.99, 15),
                new Book(21, "The Count of Monte Cristo", 1844, "Alexandre Dumas", "1234567890143", "Adventure", 9.99, 20),
                new Book(22, "One Hundred Years of Solitude", 1967, "Gabriel García Márquez", "1234567890144", "Magical Realism", 8.99, 5),
                new Book(23, "Madame Bovary", 1857, "Gustave Flaubert", "1234567890145", "Realism", 7.49, 10),
                new Book(24, "The Scarlet Letter", 1850, "Nathaniel Hawthorne", "1234567890146", "Historical", 6.99, 15),
                new Book(25, "The Sun Also Rises", 1926, "Ernest Hemingway", "1234567890147", "Fiction", 7.99, 5),
                new Book(26, "Moby-Dick", 1851, "Herman Melville", "1234567890148", "Adventure", 9.99, 10),
                new Book(27, "The Great Gatsby", 1925, "F. Scott Fitzgerald", "1234567890149", "Fiction", 10.99, 15),
                new Book(28, "Anna Karenina", 1877, "Leo Tolstoy", "1234567890150", "Romance", 8.99, 20),
                new Book(29, "Catch-22", 1961, "Joseph Heller", "1234567890151", "Satire", 7.49, 5),
                new Book(30, "Ulysses", 1922, "James Joyce", "1234567890152", "Modernist", 12.99, 10),
                new Book(31, "The Sound and the Fury", 1929, "William Faulkner", "1234567890153", "Fiction", 9.99, 15),
                new Book(32, "1984", 1949, "George Orwell", "1234567890154", "Dystopian", 8.99, 20),
                new Book(33, "The Picture of Dorian Gray", 1890, "Oscar Wilde", "1234567890155", "Philosophical", 7.99, 5),
                new Book(34, "Slaughterhouse-Five", 1969, "Kurt Vonnegut", "1234567890156", "Satire", 8.99, 10),
                new Book(35, "The Catcher in the Rye", 1951, "J.D. Salinger", "1234567890157", "Fiction", 6.99, 15),
                new Book(36, "The Trial", 1925, "Franz Kafka", "1234567890158", "Philosophical", 9.99, 20),
                new Book(37, "Don Quixote", 1605, "Miguel de Cervantes", "1234567890159", "Adventure", 10.99, 5),
                new Book(38, "Beloved", 1987, "Toni Morrison", "1234567890160", "Historical", 8.99, 10),
                new Book(39, "The Stranger", 1942, "Albert Camus", "1234567890161", "Philosophical", 7.99, 15),
                new Book(40, "A Tale of Two Cities", 1859, "Charles Dickens", "1234567890162", "Historical", 9.99, 20),
                new Book(41, "Heart of Darkness", 1899, "Joseph Conrad", "1234567890163", "Adventure", 7.99, 5),
                new Book(42, "Middlemarch", 1871, "George Eliot", "1234567890164", "Fiction", 8.99, 10),
                new Book(43, "Lolita", 1955, "Vladimir Nabokov", "1234567890165", "Fiction", 9.99, 15),
                new Book(44, "The Secret Garden", 1911, "Frances Hodgson Burnett", "1234567890166", "Children's", 6.99, 20),
                new Book(45, "Rebecca", 1938, "Daphne du Maurier", "1234567890167", "Gothic", 8.99, 5),
                new Book(46, "Of Mice and Men", 1937, "John Steinbeck", "1234567890168", "Fiction", 7.99, 10),
                new Book(47, "The Old Man and the Sea", 1952, "Ernest Hemingway", "1234567890169", "Fiction", 6.99, 15),
                new Book(48, "The Shining", 1977, "Stephen King", "1234567890170", "Horror", 9.99, 20),
                new Book(49, "Dracula", 1897, "Bram Stoker", "1234567890171", "Gothic", 7.99, 5),
                new Book(50, "The Lord of the Rings", 1954, "J.R.R. Tolkien", "1234567890172", "Fantasy", 14.99, 10)
            }
        };
        bool menuOpen = true;
        while (menuOpen)
        {
            Console.WriteLine($"{Setting.Header("Welcome to the Library Management System")}");
            Console.WriteLine(@$"
            1. Add book.
            2. Remove book.
            3. Search books.
            4. Show all books.
            5. Exit.
            ");
            int option = Setting.InputInt("Enter your option => ");
            switch (option)
            {
                case 1:
                    Console.WriteLine($"{Setting.Header("Add Book")}");
                    library.AddBook();
                    break;
                case 2:
                    Console.WriteLine($"{Setting.Header("Remove Book")}");
                    library.RemoveBook();
                    break;
                case 3:
                    Console.WriteLine($"{Setting.Header("Search Books")}");
                    Console.WriteLine(@$"
                    1. Auto search.
                    2. Search by gender.
                    3. Search by author.
                    4. Search by year range.
                    ");
                    int searchOption = Setting.InputInt("Enter your search option => ");
                    switch(searchOption)
                    {
                        case 1:
                            //library.SearchBooks();
                            break;
                        case 2:
                            string gender = Setting.InputString("Enter the gender to search by: ");
                            library.SearchGender(gender);
                            break;
                        case 3:
                            string author = Setting.InputString("Enter the author to search by: ");
                            library.SearchAuthor(author);
                            break;
                        case 4:
                            int startYear = Setting.InputInt("Enter the start year to search by: ");
                            int endYear = Setting.InputInt("Enter the end year to search by: ");
                            library.SearchYearRange(startYear, endYear);
                            break;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine($"{Setting.Header("Show All Books")}");
                    Console.WriteLine("");

                    string bookLineSeparator = new('-', 160);
                    Console.WriteLine($"{"Name", -40} | {"ISBN", -20} | {"Author", -25} | {"Genre", -15} | {"Publish Year", -15} | {"Price", -10} | {"Discount Rate", -10}");
                    Console.WriteLine(bookLineSeparator);

                    foreach (var book in library.Books)
                    {
                        Console.WriteLine($"{book.Title, -40} | {book.Isbn, -20} | {book.Author, -25} | {book.Gender, -15} | {book.PublishedOn, -15} | {book.Price, -10} | {book.DiscountRate, -10}");
                        Console.WriteLine(bookLineSeparator);
                    }
                    break;
                case 5:
                    menuOpen = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

    }
}