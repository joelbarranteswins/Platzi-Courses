public class Arrays {
    public static void main(String[] args){
        // Array de 1 dimension
        String[] androidVersions = new String[17];
        String days[] = new String[7];


        // Array de 2 dimensiones
        String[][] cities = new String[4][2];

        // Array de 3 dimensiones
        int[][][] numbers = new int[2][2][2];
        int[][][][] numbers4 = new int[2][2][2][2];

        androidVersions[0] = "Apple Pie";
        androidVersions[1] = "Bannana Bread";
        androidVersions[2] = "Cupcake";
        androidVersions[3] = "Donut";

        for (int i = 0; i < androidVersions.length; i++) {
            System.out.println(androidVersions[i]);
        }

        for (String androidVersion : androidVersions) {
            System.out.println(androidVersion);
        }

        System.out.println();

        cities[0][0] = "Colombia";
        cities[0][1] = "Medellin";
        cities[1][0] = "Colombia";
        cities[1][1] = "Bogota";
        cities[2][0] = "Mexico";
        cities[2][1] = "Guadalajara";
        cities[3][0] = "Mexico";
        cities[3][1] = "CDMX";

        for(int i = 0; i < cities.length; i++){
            for(int j = 0; j < cities[i].length; j++){
                System.out.println(cities[i][j]);
            }
        }

        for(String[] pair : cities){
            for(String name : pair){
                System.out.println(name);
            }
        }

        String [][][][] animals = new String[2][3][2][2];
        animals[1][0][0][1] = "Monkey";

        System.out.println();
        System.out.println(animals[1][0][0][1]);

        for(int i = 0; i < animals.length; i++){
            for(int j = 0; j < animals[i].length; j++){
                for(int k = 0; k < animals[i][j].length; k++){
                    for(int l = 0; l < animals[i][j][k].length; l++){
                        System.out.println(animals[i][j][k][l]);
                    }
                }
            }
        }


    }
}
