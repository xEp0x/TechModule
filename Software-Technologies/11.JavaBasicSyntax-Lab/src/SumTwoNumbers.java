import java.util.Scanner;

public class SumTwoNumbers {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        double num1 = Double.parseDouble(scan.nextLine());
        double num2 = Double.parseDouble(scan.nextLine());

        double sum = num1 + num2;
        System.out.printf("%.2f", sum);
    }
}