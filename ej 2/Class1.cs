using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_2
{
    internal class Amateur : Interfaz
    {
        int tiempoRestante = 20;
        bool estaCansado = false;

        public bool Correr(int minutos)
        {
            if(minutos <= tiempoRestante)
            {
                if(minutos == tiempoRestante)
                {
                    estaCansado = true;
                }
                else
                {
                    estaCansado = false;
                }

                tiempoRestante -= minutos;

            }
            else
            {
                estaCansado = true;
            }
            
        }

        public bool Cansado()
        {
            return estaCansado;
        }

        public void Descansar(int minutos)
        {
            
            if(tiempoRestante + minutos >= 20)
            {
                tiempoRestante = 20;
            }
            else
            {
                tiempoRestante += minutos;
            }
            if(estaCansado == true)
            {
                estaCansado = false;
            }
        }
    }
}
