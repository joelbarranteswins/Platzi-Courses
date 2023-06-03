public class DataType {
    public static void main(String[] args){

        // byte, short, int, long
        byte nB = 123;

        short nS = 12345;

        int n = 1234567890;

        long nL = 12345678901L;

        // float, double
        double nD = 123.456;

        float nF = 123.456F;

        // char
        char c = 'a';

        // boolean
        boolean b = true;

        // String
        String s = "Hello World";

        
        //using var
        var salary = 1000; // int

        var pension = salary * 0.03; // double

        System.out.println(salary);
        System.out.println(pension);

        var totalSalary = salary - pension;
        System.out.println(totalSalary);

        var employeeName = "Juan Perez";
        System.out.println("EMPLOYEE: " + employeeName + " SALARY: " + totalSalary);

    }
}
