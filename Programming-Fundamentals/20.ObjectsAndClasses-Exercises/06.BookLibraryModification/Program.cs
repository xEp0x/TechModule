using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _06.BookLibraryModification
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

            DateTime checkDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var bookAfterCheckDate = myLibrary.Books.Where(b => (b.ReleaseDate.CompareTo(checkDate) > 0))
                .OrderBy(b => b.ReleaseDate).ThenBy(b => b.Title).ToList();

            foreach (var book in bookAfterCheckDate)
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
            }           
        }
    }
}
