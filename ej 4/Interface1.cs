using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_4
{
    public interface Vehiculo
    {
        void mover(int tiempo);
        int posicion();
        void reiniciarPosicion();
    }
}
