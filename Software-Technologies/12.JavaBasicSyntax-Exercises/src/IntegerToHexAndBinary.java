import java.util.Scanner;

public class IntegerToHexAndBinary {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int num = scanner.nextInt();

        String hexadecimal = Integer.toHexString(num).toUpperCase();
        String binary = Integer.toBinaryString(num);
        System.out.println(hexadecimal);
        System.out.println(binary);
    }
}
