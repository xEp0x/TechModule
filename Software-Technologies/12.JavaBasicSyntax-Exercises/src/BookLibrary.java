import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class BookLibrary {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        Library library = new Library();
        library.setBooks(new ArrayList<Book>());
        ArrayList<Book> books = new ArrayList<Book>();

        for (int i = 0; i < n; i++) {
            String[] inputParts = scanner.nextLine().split(" ");
            Book currentBook = new Book();
            currentBook.setTitle(inputParts[0]);
            currentBook.setAuthor(inputParts[1]);
            currentBook.setPublisher(inputParts[2]);
            currentBook.setReleaseDate(inputParts[3]);
            currentBook.setISBN(inputParts[4]);
            currentBook.setPrice(Double.parseDouble(inputParts[5]));

            books.add(currentBook);
        }

        library.setBooks(books);

        HashMap<String, Double> authorPrice = new HashMap<String, Double>();

        for (Book book : library.getBooks()) {
            if (!authorPrice.containsKey(book.getAuthor())) {
                authorPrice.put(book.getAuthor(), book.getPrice());
            } else {
                authorPrice.put(book.getAuthor(), authorPrice.get(book.getAuthor()) + book.getPrice());
            }
        }

        authorPrice.entrySet()
                .stream()
                .sorted(Map.Entry.<String, Double>comparingByValue()
                        .reversed()
                        .thenComparing(Map.Entry.comparingByKey()))
                .forEach(x -> System.out.printf("%s -> %.2f%s", x.getKey(), x.getValue(), "\n"));
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

        public String releaseDate;
        public String getReleaseDate() { return releaseDate; }
        public void setReleaseDate(String releaseDate) { this.releaseDate = releaseDate; }

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
