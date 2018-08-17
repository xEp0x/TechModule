import java.util.Scanner;

public class URLParser {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        String protocol = "";
        String server = "";
        String resource = "";

        int firstIndex = input.indexOf("://");
        int secondIndex = input.indexOf("/", firstIndex + 3);

        if (firstIndex != - 1 && secondIndex != -1) {
            protocol = input.substring(0, firstIndex);
            server = input.substring(firstIndex + 3, secondIndex);
            resource = input.substring(secondIndex + 1, input.length());
        } else if (firstIndex == - 1 && secondIndex != -1) {
            server = input.substring(0, secondIndex);
            resource = input.substring(secondIndex + 1, input.length());
        } else if (firstIndex != -1 && secondIndex == -1) {
            protocol = input.substring(0, firstIndex);
            server = input.substring(firstIndex + 3, input.length());
        } else {
            server = input;
        }

        System.out.println("[protocol] = \"" + protocol.trim() + "\"");
        System.out.println("[server] = \"" + server.trim() + "\"");
        System.out.println("[resource] = \"" + resource.trim() + "\"");
    }
}
