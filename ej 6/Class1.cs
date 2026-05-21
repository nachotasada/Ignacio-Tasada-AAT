using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_6
{
    public class Carta
    {
        public string palo;
        public string numero;

        public Carta(string palo, string numero)
        {
            this.palo = palo;
            this.numero = numero;
        }

        public void mostrar()
        {
            Console.WriteLine(numero + " de " + palo);
        }
    }
}
