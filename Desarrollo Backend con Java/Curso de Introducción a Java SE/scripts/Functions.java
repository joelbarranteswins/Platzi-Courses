public class Functions {
    public static void main(String[] args) {
        double r = 3;

        double area = circleArea(r);
        System.out.println("Circle area: " + area);

        double areaSphere = sphereArea(r);
        System.out.println("Sphere area: " + areaSphere);

        double volume = sphereVolume(r);
        System.out.println("Sphere volume: " + volume);
    }

    /**
     * return area of a circle
     * <ul><li>Formula: PI * r^2</li></ul>
     * 
     * @param r radius of the circle
     */
    public static double circleArea(double r) {
        return Math.PI * Math.pow(r, 2);
    }

    public static double sphereArea(double r) {
        return 4 * Math.PI * Math.pow(r, 2);
    }

    public static double sphereVolume(double r) {
        return (4/3) * Math.PI * Math.pow(r, 3);
    }
}
