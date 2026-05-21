using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_3
{
    public class Profesional : Jugador
    {
        public int tiempoRestante = 40;
        public bool estaCansado = false;

        public bool correr(int minutos)
        {
            if (estaCansado)
            {
                Console.WriteLine("El profesional está cansado, debe descansar.");
                return false;
            }

            if (minutos <= tiempoRestante)
            {
                tiempoRestante -= minutos;
                if (tiempoRestante == 0)
                {
                    estaCansado = true;
                }
                return true;
            }
            else
            {
                tiempoRestante = 0;
                estaCansado = true;
                return false;
            }
        }

        public bool cansado()
        {
            return estaCansado;
        }

        public void descansar(int minutos)
        {
            tiempoRestante += minutos;
            if (tiempoRestante > 40)
            {
                tiempoRestante = 40;
            }
            estaCansado = false;
        }
    }
}
