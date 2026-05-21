using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_6
{
    public class Mazo
    {
        public List<Carta> cartas;

        public Mazo()
        {
            cartas = new List<Carta>();

            string[] palos = { "Espadas", "Bastos", "Oros", "Copas" };
            string[] numeros = { "1", "2", "3", "4", "5", "6", "7", "Sota", "Caballo", "Rey" };

            foreach (string palo in palos)
            {
                foreach (string numero in numeros)
                {
                    cartas.Add(new Carta(palo, numero));
                }
            }
        }

        public void barajar()
        {
            Random rnd = new Random();
            for (int i = cartas.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                Carta temp = cartas[i];
                cartas[i] = cartas[j];
                cartas[j] = temp;
            }
        }

        public Carta robarCarta()
        {
            if (cartas.Count == 0)
            {
                Console.WriteLine("Error: el mazo esta vacio.");
                return null;
            }

            Carta carta = cartas[cartas.Count - 1];
            cartas.RemoveAt(cartas.Count - 1);
            return carta;
        }

        public int cuantasCartasQuedan()
        {
            return cartas.Count;
        }
    }
}
