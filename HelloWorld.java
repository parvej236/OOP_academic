import java.util.Random;

public class HelloWorld {
    public static void main(String[] args) {
        System.out.println("Hello, World!");

        Random rand = new Random();
        int aray[] = new int[100];

        for (int i = 0; i < aray.length; i++) {
            aray[i] = 0;
        }

        for (int i = 0; i < 1000000000; i++) {
            // System.out.print(rand.nextInt(100) + ",");
            int r = rand.nextInt(100);
            aray[r]++;
        }

        for (int i = 0; i < 100; i++) {
            System.out.println( i + ": " + aray[i] + " times");
        }
    }
}
