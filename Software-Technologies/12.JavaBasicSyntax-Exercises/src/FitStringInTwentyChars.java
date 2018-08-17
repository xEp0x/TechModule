import java.util.Scanner;

public class FitStringInTwentyChars {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String str = scanner.nextLine();

        if (str.length() >= 20) {
            System.out.println(str.substring(0, 20));
        } else {
            int count = 20 - str.length();
            StringBuilder sb = new StringBuilder(str);

            for (int i = 0; i < count; i++) {
                sb.append('*');
            }

            System.out.println(sb);
        }
    }
}
