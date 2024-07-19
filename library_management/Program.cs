using library_management.Models;

namespace library_management;

public class Program
{
    public static void Main(string[] args)
    {
        bool menuOpen = true;
        while (menuOpen)
        {
            Console.WriteLine($"{Setting.Header("Welcome to the Library Management System")}");
            Console.WriteLine(@$"
            1. Add book.
            2. Remove book.
            3. Search books.
            4. Exit.
            ");
            int option = Setting.InputInt("Enter your option => ");
            switch (option)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    menuOpen = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

    }
}