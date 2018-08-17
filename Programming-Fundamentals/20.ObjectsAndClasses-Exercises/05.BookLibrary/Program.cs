using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _05.BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookCount = int.Parse(Console.ReadLine());
            var myLibrary = new Library() { Name = "Personal", Books = new List<Book>() };

            for (int i = 0; i < bookCount; i++)
            {
                //format {title} {author} {publisher} {release date} {ISBN} {price}
                var inputLine = Console.ReadLine().Split().ToList();

                var title = inputLine[0];
                var author = inputLine[1];
                var publisher = inputLine[2];
                var releaseDate = DateTime.ParseExact(inputLine[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var isbn = inputLine[4];
                var price = decimal.Parse(inputLine[5]);

                var currentBook = new Book(title, author, publisher, releaseDate, isbn, price);

                myLibrary.Books.Add(currentBook);
            }

            var authorSales = myLibrary.Books
                .Select(a => a.Author)
                .Distinct()
                .Select(author => new  // anonymous class
                {
                    Author = author,
                    Sales = myLibrary.Books.Where(book => book.Author == author).Sum(b => b.Price)
                })
                .OrderByDescending(authorInfo => authorInfo.Sales)
                .ThenBy(a => a.Author)
                .ToList();

            foreach (var author in authorSales)
            {
                Console.WriteLine($"{author.Author} -> {author.Sales:F2}");
            }

            // Sorted Dictionary variant 

            //     var authorsSumPrices = new SortedDictionary<string, decimal>();
            //
            //     foreach (var book in myLibrary.Books)
            //     {
            //         var currentAuthor = book.Author;
            //         var currentPrice = book.Price;
            //
            //         if (!authorsSumPrices.ContainsKey(currentAuthor))
            //         {
            //             authorsSumPrices[currentAuthor] = 0;
            //         }
            //
            //         authorsSumPrices[currentAuthor] += book.Price;
            //     }
            //
            //     foreach (var author in authorsSumPrices.OrderByDescending(price => price.Value))
            //     {
            //         var currentAuthor = author.Key;
            //         var sumPriceByAuthor = author.Value;
            //         Console.WriteLine($"{currentAuthor} -> {sumPriceByAuthor:F2}");
            //     }
        }
    }
}
