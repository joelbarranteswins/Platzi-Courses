//Upper Camel Case
public class NamingVariables {
    public static void main(String[] args){
        int cellphone = 12345678;
        int cellPhone = 87654321;

        System.out.println(cellphone);
        System.out.println(cellPhone);

        String $countryName = "Spain";
        String _backgroundColor = "Green";

        System.out.println($countryName);
        System.out.println(_backgroundColor);
        
        //No se puede poner guion medio
        //String background-color = "Blue";
    
        String currency$ = "MXN";
        String background_color = "Blue";

        System.out.println($countryName);
        System.out.println(_backgroundColor);


        /*Varibales Constantes */

        int POSITION = -5;
        int MAX_WIDTH = 9999;
        int MIN_WIDTH = 1;

        /*se agrega la palabra reservada final en la declaración de la variable para convertirla en constante*/
        //para que nunca cambie su valor
        final int MAX_WIDTH_DEFINE = 100;
    }
}
