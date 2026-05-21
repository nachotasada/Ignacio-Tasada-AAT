using System;

namespace ej_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto fiat = new Auto(45);
            Bicicleta bici = new Bicicleta();
            Camion camion = new Camion();

            bici.mover(20);
            Console.WriteLine(bici.posicion());
            bici.mover(10);
            Console.WriteLine(bici.posicion());

            Console.WriteLine("--- Carrera: Auto vs Camion ---");
            Carrera carrera = new Carrera(fiat, camion);
            carrera.correr(10);
        }
    }
}
