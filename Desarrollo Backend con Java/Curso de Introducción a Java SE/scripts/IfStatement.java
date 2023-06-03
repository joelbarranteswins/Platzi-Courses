public class IfStatement {
    public static void main(String[] args) {
        boolean isBluetoothEnabled = false; // también podría ser false
        int fileSended = 3;

        if (isBluetoothEnabled) {
            fileSended++;
            System.out.println("Archivo enviado");
        }
        else{
            fileSended--;
            System.out.println("Por favor enciende tu Bluetooth para iniciar la transferencia");
        }

        System.out.println(isBluetoothEnabled);
        System.out.println(fileSended);
    }
}
