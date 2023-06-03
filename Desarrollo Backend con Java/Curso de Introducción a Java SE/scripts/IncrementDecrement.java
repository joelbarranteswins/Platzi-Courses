public class IncrementDecrement {
    public static void main(String[] args){
        int lives = 5;
        lives = lives - 1;
        System.out.println(lives); // 4
        
        //sufijo
        lives--; // decrement
        System.out.println(lives); // 3

        lives++; // increment
        System.out.println(lives); // 4

        //prefijo
        // Gana un regalo por ganar una vida
        int gift = 100 + lives++; // post-increment
        System.out.println(gift); // 104

        int gift2 = 100 + ++lives; // pre-increment
        System.out.println(gift2); // 106

        
    }
}
