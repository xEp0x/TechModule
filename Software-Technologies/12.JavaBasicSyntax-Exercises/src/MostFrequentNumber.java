import java.util.Scanner;

public class MostFrequentNumber {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] numsAsString = scanner.nextLine().split("\\s");
        int[] nums = new int[numsAsString.length];

        for (int i = 0; i < nums.length; i++) {
            nums[i] = Integer.parseInt(numsAsString[i]);
        }

        int number = 0;
        int countNumber = 0;
        int bestNumber = 0;
        int bestCountNumber = 0;

        for (int i = 0; i < nums.length; i++) {
            for (int j = 0; j < nums.length; j++) {
                if (nums[i] == nums[j]) {
                    number = nums[i];
                    countNumber++;
                }
                if (countNumber > bestCountNumber) {
                    bestCountNumber = countNumber;
                    bestNumber = number;
                }
            }

            countNumber = 0;
        }

        System.out.println(bestNumber);
    }
}
