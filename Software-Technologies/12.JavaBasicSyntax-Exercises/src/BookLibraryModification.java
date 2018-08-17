import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class BookLibraryModification {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        Library library = new Library();
        library.setBooks(new ArrayList<Book>());
        ArrayList<Book> books = new ArrayList<Book>();
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd.MM.yyyy");

        for (int i = 0; i < n; i++) {
            String[] inputParts = scanner.nextLine().split(" ");
            Book currentBook = new Book();
            currentBook.setTitle(inputParts[0]);
            currentBook.setAuthor(inputParts[1]);
            currentBook.setPublisher(inputParts[2]);
            currentBook.setReleaseDate(LocalDate.from(formatter.parse(inputParts[3])));
            currentBook.setISBN(inputParts[4]);
            currentBook.setPrice(Double.parseDouble(inputParts[5]));

            books.add(currentBook);
        }

        library.setBooks(books);

        String dateString = scanner.nextLine();
        LocalDate date = LocalDate.from(formatter.parse(dateString));

        List<Book> titleDate = library.getBooks()
                .stream()
                .filter(x -> x.getReleaseDate().isAfter(date))
                .sorted(Comparator.comparing(Book::getReleaseDate)
                        .thenComparing(Book::getTitle))
                .collect(Collectors.toList());

        for (int i = 0; i < titleDate.size(); i++) {
            System.out.printf("%s -> %s%s", titleDate.get(i).getTitle(), titleDate.get(i).getReleaseDate().format(formatter), "\n");
        }
    }

    public static class Book {
        public String title;
        public String getTitle() {
            return title;
        }
        public void setTitle(String title) {
            this.title = title;
        }

        public String author;
        public String getAuthor() { return author; }
        public void setAuthor(String author) { this.author = author; }

        public String publisher;
        public String getPublisher() { return publisher; }
        public void setPublisher(String publisher) { this.publisher = publisher; }

        public LocalDate releaseDate;
        public LocalDate getReleaseDate() { return releaseDate; }
        public void setReleaseDate(LocalDate releaseDate) { this.releaseDate = releaseDate; }

        public String ISBN;
        public String getISBN() { return ISBN; }
        public void setISBN(String ISBN) { this.ISBN = ISBN; }

        public double price;
        public double getPrice() { return price; }
        public void setPrice(double price) { this.price = price; }
    }

    public static class Library {
        public String name;
        public String getName() { return name; }
        public void setName(String name) { this.name = name; }

        public ArrayList<Book> Books;
        public ArrayList<Book> getBooks() { return Books; }
        public void setBooks(ArrayList<Book> books) { this.Books = books; }
    }
}
