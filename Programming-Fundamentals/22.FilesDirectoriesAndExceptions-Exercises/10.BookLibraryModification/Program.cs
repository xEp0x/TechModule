using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace _10.BookLibraryModification
{
    class BookLibraryModification
    {
        static void Main(string[] args)
        {
            string[] fileLines = File.ReadAllLines(@"input.txt");
            var myLibrary = new Library() { Name = "Personal", Books = new List<Book>() };

            for (int i = 0; i < fileLines.Length - 1; i++)
            {
                //format {title} {author} {publisher} {release date} {ISBN} {price}
                var inputLine = fileLines[i].Split().ToList();
                var title = inputLine[0];
                var author = inputLine[1];
                var publisher = inputLine[2];
                var releaseDate = DateTime.ParseExact(inputLine[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var isbn = inputLine[4];
                var price = decimal.Parse(inputLine[5]);
                var currentBook = new Book(title, author, publisher, releaseDate, isbn, price);

                myLibrary.Books.Add(currentBook);
            }

            DateTime checkDate = DateTime.ParseExact(fileLines.Last(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var bookAfterCheckDate = myLibrary.Books.Where(b => (b.ReleaseDate.CompareTo(checkDate) > 0))
                .OrderBy(b => b.ReleaseDate).ThenBy(b => b.Title).ToList();

            File.WriteAllText(@"output.txt", string.Empty);

            foreach (var book in bookAfterCheckDate)
            {
                File.AppendAllText(@"output.txt", $"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}\n");
            }
        }
    }
}
