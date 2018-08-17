using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace _09.BookLibrary
{
    class BookLibrary
    {
        static void Main(string[] args)
        {
            string[] fileLines = File.ReadAllLines(@"input.txt");
            var myLibrary = new Library() { Name = "Personal", Books = new List<Book>() };

            for (int i = 0; i < fileLines.Length; i++)
            {
                //format {title} {author} {publisher} {release date} {ISBN} {price}
                var fileLine = fileLines[i].Split().ToList();
                var title = fileLine[0];
                var author = fileLine[1];
                var publisher = fileLine[2];
                var releaseDate = DateTime.ParseExact(fileLine[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var isbn = fileLine[4];
                var price = decimal.Parse(fileLine[5]);
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

            File.WriteAllText(@"output.txt", string.Empty);

            foreach (var author in authorSales)
            {
                File.AppendAllText(@"output.txt", $"{author.Author} -> {author.Sales:F2}\n");
            }
        }
    }
}
