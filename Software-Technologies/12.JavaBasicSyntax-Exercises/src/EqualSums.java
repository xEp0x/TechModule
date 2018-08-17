import java.util.Scanner;

public class EqualSums {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] numsAsString = scanner.nextLine().split("\\s");
        int[] nums = new int[numsAsString.length];

        for (int i = 0; i < nums.length; i++) {
            nums[i] = Integer.parseInt(numsAsString[i]);
        }

        int index = 0;

        for (int i = 0; i < nums.length; i++) {
            int leftSum = 0;
            int rightSum = 0;
            index = i;

            for (int leftNum = 0; leftNum <= (i - 1); leftNum++) {
                leftSum += nums[leftNum];
            }
            for (int rightNum = i + 1; rightNum < nums.length; rightNum++) {
                rightSum += nums[rightNum];
            }
            if (leftSum == rightSum) {
                System.out.println(index);
                return;
            }
        }

        System.out.println("no");
    }
}
