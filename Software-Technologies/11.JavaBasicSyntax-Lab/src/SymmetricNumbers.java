import java.util.Scanner;

public class SymmetricNumbers {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int number = Integer.parseInt(scan.nextLine());

        for (int i = 1; i <= number; i++) {
            String currentNumber = "" + i;
            if (IsSymetric(currentNumber)){
                System.out.printf("%s ", currentNumber);
            }
        }
    }

    private static boolean IsSymetric(String number) {
        for (int i = 0; i < number.length() / 2; i++) {
            if (number.charAt(i) != number.charAt(number.length() - i - 1)) {
                return false;
            }
        }
        return true;
    }
}
