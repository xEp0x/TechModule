import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class PhonebookUpgrade {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();
        TreeMap<String, String> phonebook = new TreeMap<>();

        while (!input.equals("END")) {
            String[] inputParts = input.split(" ");
            String command = inputParts[0];

            if (command.equals("A")) {
                String name = inputParts[1];
                String number = inputParts[2];

                if (!phonebook.containsKey(name)) {
                    phonebook.put(name, number);
                } else {
                    phonebook.remove(name);
                    phonebook.put(name, number);
                }
            } else if (command.equals("S")) {
                String name = inputParts[1];

                if (!phonebook.containsKey(name)) {
                    System.out.printf("Contact %s does not exist.%s", name, "\n");
                } else {
                    System.out.printf("%s -> %s%s", name, phonebook.get(name), "\n");
                }
            } else if (command.equals("ListAll")) {
                for (Map.Entry<String, String> kvp : phonebook.entrySet()) {
                    System.out.printf("%s -> %s%s", kvp.getKey(), kvp.getValue(), "\n");
                }
            }

            input = scanner.nextLine();
        }
    }
}
