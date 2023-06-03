package exercise;

public class Exercise {
    public static void main(String[] args) {
        Ejercicio_1();

        Ejercicio_2();

        byte i = 1; 
        byte j = 1; 
        byte k = i+j;
        System.out.println(k);
    }

    public static void Ejercicio_1() {
        
        String father = "Juan";

        String mother = "Maria";

        String son = "Pedro";

        String daughter = "Ana";

        System.out.println("Father: " + father + "\nMother: " + mother + "\nSon: " + son + "\nDaughter: " + daughter);
    }

    public static void Ejercicio_2() {
        char a = 'z'; //conviertelo a int
        System.out.println(a);
        System.out.println((int) a);

        int b = 250; // conviertelo a long y luego de long a short
        System.out.println(b);
        System.out.println((long) b);
        System.out.println((short)b);

        double c = 301.067; // conviertelo a long
        System.out.println(c);
        System.out.println((long) c);

        int d = 100; // súmale 5000.66 y conviertelo a float
        System.out.println(d);
        System.out.println((float) (d + 5000.66));

        int e = 737; // multiplícalo por 100 y conviertelo a byte
        System.out.println(e);
        System.out.println((byte) (e * 100));

        double f = 298.638; // divídelo entre 25 y conviertelo a long
        System.out.println(f);
        System.out.println((long) (f / 25));

    }

    public static void Ejercicio_3(String name) {
        System.out.println("Hello " + name);
    }
}
