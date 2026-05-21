using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_4
{
    public class Camion : Vehiculo
    {
        public int velocidad = 30;
        public int posicionActual = 0;

        public void mover(int tiempo)
        {
            posicionActual += velocidad * tiempo;
        }

        public int posicion()
        {
            return posicionActual;
        }

        public void reiniciarPosicion()
        {
            posicionActual = 0;
        }
    }
}
