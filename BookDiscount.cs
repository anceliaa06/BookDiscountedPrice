using System;

namespace BookDiscountApp
{
    class Book
    {
        public string Title;
        public string Author;
        public double Price;
        public bool IsBestSeller;

        //constructor
        public Book(string title, string author, double price, bool isBestSeller)
        {
            Title = title;
            Author = author;
            Price = price;
            IsBestSeller = isBestSeller;
        }

        //method to calculate and display discounted price
        public void CalculateDiscountedPrice()
        {
            Console.WriteLine($"\ntitle: {Title}");
            Console.WriteLine($"author: {Author}");
            Console.WriteLine($"original price : {Price:0.0}");

            double discountedPrice = Price;

            if (IsBestSeller)
            {
                Console.WriteLine($"'{Title}' is a bestseller. ");
                discountedPrice *= 0.90;
            }
            if (Price > 500)
            {
                Console.WriteLine($"'{Title}' is priced over 500. applying 5% discount");
                discountedPrice *= 0.95;

            }
            Console.WriteLine($"final discounted price: ${discountedPrice:0.00}");

        }
    }
    class Program
    {
        static void Main()
        {
            Book book1 = new Book("The Power of Habit", "Charles Duhigg", 600.00, true);
            Book book2 = new Book("C# Programming", "Jane Doe", 450.00, false);

            book1.CalculateDiscountedPrice();
            book2.CalculateDiscountedPrice();
        }
    }
}

