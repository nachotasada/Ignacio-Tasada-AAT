using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_3
{
    public interface Jugador
    {
        bool correr(int minutos);
        bool cansado();
        void descansar(int minutos);
    }
}
