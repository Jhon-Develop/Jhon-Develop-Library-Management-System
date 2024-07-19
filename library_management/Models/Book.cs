using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_management.Models
{
    public class Book(int id, string title, int publishedOn, string author, string isbn, string gender, double price, double discountRate) : Publication(id, title, publishedOn)
    {
        private new int Id { get; set;}
        public string Author { get; set; } = author;
        public string Isbn { get; set; } = isbn;
        public string Gender { get; set; } = gender;
        public double Price { get; set; } = price;
        public double DiscountRate { get; set; } = discountRate;

        public void ShowBookInfo()
        {
            Console.WriteLine($"The author of th book is {Author}, the titlle is {Title}, the gender is {Gender}, the price is {Price} and has a discount rate of {DiscountRate}.");
        }
        public double CalculateDiscount(double discountRate)
        {
            double PriceDiscount = Price * ( 1 - discountRate / 100 );
            return PriceDiscount;
        }
    }
}