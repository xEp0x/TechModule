import java.util.Scanner;

public class ChangeToUppercase {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String text = scanner.nextLine();
        int startIndex = text.indexOf("<upcase>");
        int endIndex = text.indexOf("</upcase>");

        while (startIndex != -1) {
            String upperToReplace = text.substring(startIndex, endIndex + 9);
            String upperCaseText = text.substring(startIndex, endIndex + 9).toUpperCase();
            String upperText = upperCaseText.substring(8, upperCaseText.length() - 9);
            text = text.replace(upperToReplace, upperText);

            startIndex = text.indexOf("<upcase>");
            endIndex = text.indexOf("</upcase>");
        }

        System.out.println(text);
    }
}
