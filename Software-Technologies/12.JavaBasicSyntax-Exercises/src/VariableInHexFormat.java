import java.util.Scanner;

public class VariableInHexFormat {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String numberAsString = scan.nextLine();
        int number = Integer.parseInt(numberAsString, 16);

        System.out.println(number);
    }
}
