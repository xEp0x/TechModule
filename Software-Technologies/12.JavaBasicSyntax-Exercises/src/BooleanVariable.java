import java.util.Scanner;

public class BooleanVariable {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Boolean bool = scanner.nextBoolean();
        if (bool.equals(true)) {
            System.out.println("Yes");
        } else {
            System.out.println("No");
        }
    }
}
