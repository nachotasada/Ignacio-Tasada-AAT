using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_4
{
    public class Carrera
    {
        public Vehiculo vehiculo1;
        public Vehiculo vehiculo2;

        public Carrera(Vehiculo v1, Vehiculo v2)
        {
            vehiculo1 = v1;
            vehiculo2 = v2;
        }

        public void correr(int segundos)
        {
            vehiculo1.mover(segundos);
            vehiculo2.mover(segundos);

            Console.WriteLine("Posicion vehiculo 1: " + vehiculo1.posicion() + " metros");
            Console.WriteLine("Posicion vehiculo 2: " + vehiculo2.posicion() + " metros");

            if (vehiculo1.posicion() > vehiculo2.posicion())
            {
                Console.WriteLine("Gano el vehiculo 1!");
            }
            else if (vehiculo2.posicion() > vehiculo1.posicion())
            {
                Console.WriteLine("Gano el vehiculo 2!");
            }
            else
            {
                Console.WriteLine("Empate!");
            }
        }
    }
}
