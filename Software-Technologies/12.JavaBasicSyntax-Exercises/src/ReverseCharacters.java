import java.util.Scanner;

public class ReverseCharacters {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String result = "";
        for (int i = 0; i < 3; i++) {
            String letter = scanner.nextLine();
            result += letter;
        }

        String reverseResult = "";
        for (int i = result.length() - 1; i >= 0; i--) {
            reverseResult += result.charAt(i);
        }

        System.out.println(reverseResult);
    }
}
