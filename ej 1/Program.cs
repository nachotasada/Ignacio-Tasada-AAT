using System;

namespace ej_1
{

    public class Semaforo
    {
        public string colorActual;
        public string colorAnterior;
        public int tiempo;
        public bool esIntermitente;


        
        public Semaforo(string colorInicial)
        {
            colorActual = colorInicial;
            colorAnterior = "";
            tiempo = 0;
            esIntermitente = false;
        }



        public void PasoDelTiempo(int segundos)
        {
            if (esIntermitente)
            {
                for (int i = 0; i < segundos; i++)
                {
                    tiempo++;
                    if (tiempo >= 1)
                    {
                        tiempo = 0;
                        colorActual = colorActual == "Amarillo" ? "Apagado" : "Amarillo";
                    }
                }
            }
            else
            {
                tiempo += segundos;

                if (colorActual == "Rojo" && tiempo >= 30)
                {
                    colorActual = "Rojo + Amarillo";
                    tiempo = 0;
                }
                else if (colorActual == "Rojo + Amarillo" && tiempo >= 2)
                {
                    colorActual = "Verde";
                    tiempo = 0;
                }
                else if (colorActual == "Verde" && tiempo >= 20)
                {
                    colorActual = "Amarillo";
                    tiempo = 0;
                }
                else if (colorActual == "Amarillo" && tiempo >= 2)
                {
                    colorActual = "Rojo";
                    tiempo = 0;
                }
            }
        }

        public void MostrarColor()
        {
            Console.WriteLine(colorActual);
        }

        public void PonerEnIntermitente()
        {
            tiempo = 0;
            esIntermitente = true;
            colorActual = "Amarillo";
        }

        public void SacarDelIntermitente()
        {
            tiempo = 0;
            esIntermitente= false;
            colorActual = "Rojo";
        }









    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            
        }
    }
}
