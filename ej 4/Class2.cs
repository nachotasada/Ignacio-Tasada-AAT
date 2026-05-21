using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_4
{
    public class Auto : Vehiculo
    {
        public int velocidad;
        public int posicionActual = 0;

        public Auto()
        {
            velocidad = 40;
        }

        public Auto(int velocidad)
        {
            this.velocidad = velocidad;
        }

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
