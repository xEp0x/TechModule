import java.util.Scanner;

public class CensorEmailAddress {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String email = scanner.nextLine();
        String text = scanner.nextLine();

        int index = email.indexOf('@');
        StringBuilder censorEmail = new StringBuilder();
        for (int i = 0; i < index; i++) {
            censorEmail.append("*");
        }
        censorEmail.append(email.substring(index, email.length()));

        String censorText = text.replace(email, censorEmail);
        System.out.println(censorText);
    }
}
