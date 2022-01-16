
class Car {
    Integer id;
    String license;
    Integer passenger;
    Account driver;

    public Car(String license, Account driver) {
        this.license = license;
        this.driver = driver;
    }

    void printDataCar(){
        System.out.println("License: " + license + " Driver: " + driver + " Passenger: " + passenger);
    }
}