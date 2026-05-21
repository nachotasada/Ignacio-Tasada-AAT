using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_6
{
    public class Mano
    {
        public List<Carta> cartasEnMano;

        public Mano()
        {
            cartasEnMano = new List<Carta>();
        }

        public void recibirCarta(Carta carta)
        {
            cartasEnMano.Add(carta);
        }

        public void mostrarMano()
        {
            foreach (Carta carta in cartasEnMano)
            {
                carta.mostrar();
            }
        }

        public int cantidadDeCartas()
        {
            return cartasEnMano.Count;
        }
    }
}
