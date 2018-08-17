import java.util.Scanner;

public class CompareCharArrays {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] first = scanner.nextLine().split("\\s");
        String[] second = scanner.nextLine().split("\\s");

        String firstAsString = "";
        String secondAsString = "";

        for (int i = 0; i < first.length; i++) {
            firstAsString += first[i];
        }

        for (int i = 0; i < second.length; i++) {
            secondAsString += second[i];
        }

        int shorter = Math.min(firstAsString.length(), secondAsString.length());

        for (int i = 0; i < shorter; i++) {
            if (firstAsString.charAt(i) < secondAsString.charAt(i)) {
                System.out.println(firstAsString);
                System.out.println(secondAsString);
                return;
            } else if (firstAsString.charAt(i) > secondAsString.charAt(i)) {
                System.out.println(secondAsString);
                System.out.println(firstAsString);
                return;
            }
        }

        if (firstAsString.length() < secondAsString.length()) {
            System.out.println(firstAsString);
            System.out.println(secondAsString);
        } else {
            System.out.println(secondAsString);
            System.out.println(firstAsString);
        }
    }
}
