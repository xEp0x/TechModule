public class CalculateExpression {

    public static void main(String[] args) {
        double expression = (30 + 21) * (1/2.0) * ((35 - 12) - (1/2.0));
        double pow = Math.pow(expression, 2);
        System.out.println(pow);
    }
}
