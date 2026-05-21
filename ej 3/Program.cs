using System;

namespace ej_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Amateur amateur = new Amateur();
            Profesional profesional = new Profesional();

            Console.WriteLine("--- Jugador Amateur ---");
            Console.WriteLine(amateur.correr(15));   // true
            Console.WriteLine(amateur.cansado());    // false
            Console.WriteLine(amateur.correr(10));   // false, se cansa
            Console.WriteLine(amateur.cansado());    // true
            amateur.descansar(10);
            Console.WriteLine(amateur.cansado());    // false

            Console.WriteLine("--- Jugador Profesional ---");
            Console.WriteLine(profesional.correr(40));  // true, pero queda cansado
            Console.WriteLine(profesional.cansado());   // true
            profesional.descansar(20);
            Console.WriteLine(profesional.cansado());   // false
        }
    }
}
