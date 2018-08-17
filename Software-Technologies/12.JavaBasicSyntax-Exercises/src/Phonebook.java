import java.util.LinkedHashMap;
import java.util.Scanner;

public class Phonebook {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();
        LinkedHashMap<String, String> phonebook = new LinkedHashMap<>();

        while (!input.equals("END")) {
            String[] inputParts = input.split(" ");
            String command = inputParts[0];
            String name = inputParts[1];

            if (command.equals("A")) {
                String number = inputParts[2];

                if(!phonebook.containsKey(name)) {
                    phonebook.put(name, number);
                } else {
                    phonebook.remove(name);
                    phonebook.put(name, number);
                }
            }

            if (command.equals("S")) {
                if (!phonebook.containsKey(name)) {
                    System.out.printf("Contact %s does not exist.%s", name, "\n");
                } else {
                    System.out.printf("%s -> %s %s", name, phonebook.get(name), "\n");
                }
            }

            input = scanner.nextLine();
        }
    }
}
