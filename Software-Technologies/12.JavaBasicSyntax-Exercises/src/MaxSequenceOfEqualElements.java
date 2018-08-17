import java.util.Arrays;
import java.util.Scanner;

public class MaxSequenceOfEqualElements {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] array = Arrays.stream(scanner.nextLine().split("\\s")).mapToInt(Integer::parseInt).toArray();

        int startPos = 0;
        int bestStartPos = 0;
        int length = 1;
        int bestLength = 1;

        for (int i = 1; i < array.length; i++) {
            if (array[i] == array[i - 1]) {
                length++;

                if (length == 2) {
                    startPos = i - 1;
                }
                if (length > bestLength) {
                    bestLength = length;
                    bestStartPos = startPos;
                }
            } else {
                length = 1;
            }
        }

        for (int i = bestStartPos; i < bestStartPos + bestLength; i++) {
            System.out.print(array[i] + " ");
        }
    }
}
