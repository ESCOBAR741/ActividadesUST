public class Coche {
    private static Coche instancia;
    private Coche() {
    }
    //Creamos el método que coompara si existe
    public static Coche getInstancia() {
        if(instancia == null) {
            instancia = new Coche();
            System.out.println("El objeto ha sido creado");
        }else {
            System.out.println("Ya exite el objeto");
        }

        return instancia;
    }

}
