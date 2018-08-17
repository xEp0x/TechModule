import java.util.Scanner;

public class SumNIntegers {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int count = Integer.parseInt(scan.nextLine());

        int sum = 0;
        for (int i = 0; i < count; i++) {
            int currentNumber = scan.nextInt();
            sum += currentNumber;
        }

        System.out.printf("Sum = %d", sum);
    }
}
