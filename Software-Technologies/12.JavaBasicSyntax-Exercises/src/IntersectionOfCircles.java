import java.util.Scanner;

public class IntersectionOfCircles {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] firstRow = scanner.nextLine().split(" ");
        String[] secondRow = scanner.nextLine().split(" ");

        Circle firstCircle = new Circle();
        firstCircle.center.setX(Double.parseDouble(firstRow[0]));
        firstCircle.center.setY(Double.parseDouble(firstRow[1]));
        firstCircle.setRadius(Double.parseDouble(firstRow[2]));

        Circle secondCircle = new Circle();
        secondCircle.center.setX(Double.parseDouble(secondRow[0]));
        secondCircle.center.setY(Double.parseDouble(secondRow[1]));
        secondCircle.setRadius(Double.parseDouble(secondRow[2]));

        double distance = Math.sqrt(Math.pow(firstCircle.center.getX() - secondCircle.center.getX(), 2) + Math.pow(firstCircle.center.getY() - secondCircle.center.getY(), 2));
        double sumOfRadius = firstCircle.radius + secondCircle.radius;

        if (distance <= sumOfRadius) {
            System.out.println("Yes");
        } else {
            System.out.println("No");
        }
    }

    public static class Circle {
        private Point center = new Point();
        private double radius;

        public double getRadius() {
            return radius;
        }
        private void setRadius(double radius) {
            this.radius = radius;
        }

        public class Point {
            private double X;
            private double Y;

            private double getX() {
                return X;
            }

            private void setX(double x) {
                X = x;
            }

            private double getY() {
                return Y;
            }

            private void setY(double y) {
                Y = y;
            }
        }
    }
}
