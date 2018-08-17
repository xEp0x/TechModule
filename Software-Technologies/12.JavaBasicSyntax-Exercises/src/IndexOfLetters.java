import java.util.Scanner;

public class IndexOfLetters {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String word = scanner.nextLine();

        for (int i = 0; i < word.length(); i++) {
            int index = word.charAt(i) - 97;
            System.out.println(word.charAt(i) + " -> " + index);
        }
    }
}
