import java.util.Scanner;

public class MaxSequenceOfIncreasingElements {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] numsAsString = scanner.nextLine().split(" ");
        int[] nums = new int[numsAsString.length];

        for (int i = 0; i < nums.length; i++) {
            nums[i] = Integer.parseInt(numsAsString[i]);
        }

        int startPos = 0;
        int bestStartPos = 0;
        int length = 1;
        int bestLength = 1;

        for (int i = 1; i < nums.length; i++) {
            if (nums[i] > nums[i - 1]) {
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

        for (int i = bestStartPos; i < (bestStartPos + bestLength); i++) {
            System.out.print(nums[i] + " ");
        }
    }
}
