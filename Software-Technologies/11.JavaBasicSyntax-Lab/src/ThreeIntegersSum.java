import java.util.Scanner;

public class ThreeIntegersSum {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int num1 = scan.nextInt();
        int num2 = scan.nextInt();
        int num3 = scan.nextInt();

        if (!checkNumbers(num1, num2, num3) && !checkNumbers(num1, num3, num2) && !checkNumbers(num2, num3, num1)){
            System.out.println("No");
        }
    }

    private static boolean checkNumbers(int num1, int num2, int num3) {
        if (num1 + num2  == num3) {
            if (num1 > num2) {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            System.out.printf("%d + %d = %d", num1, num2, num3);
            return true;
        }
        return false;
    }
}
