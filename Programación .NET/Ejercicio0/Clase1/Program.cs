using Clase1;

class Program
{
    public static void Main (string [] args)
    {
        Console.WriteLine("Moto........");
        Vehiculo instanciarMoto = new Vehiculo("Honda", "Urban");
        instanciarMoto.avanzar();
        instanciarMoto.frenar();

        Console.WriteLine("Avion.......");
        Avion instanciarAvion = new Avion("Boeing", "777");
        instanciarAvion.volar();
        instanciarAvion.tipoCombustible();

        Vehiculo[] auto = new Vehiculo[2];
        auto[0] = new Avion("CargoPlane", "Carga");
        auto[1] = new Moto("Opresor", "MK2");

        for (int i=0; i<2; i++)
        {
            auto[i].tipoCombustible();
        }

        Console.WriteLine("Bote........");
        Bote instanciarBote = new Bote("Buque", "STX");
        instanciarBote.remar();

    }
}