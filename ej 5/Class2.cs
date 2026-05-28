using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_5
{
    public class CajaDeAhorro : CuentaBancaria
    {
        public override bool extraer(int monto)
        {
            if (monto < 0)
            {
                Console.WriteLine("El monto tiene q ser mayor a 0");
                return false;
            }

            if (ObtenerSaldo() < monto)
            {
                Console.WriteLine("Saldo insuficiente en la Caja de Ahorro.");
                return false;
            }

            int nuevoSaldo = ObtenerSaldo() - monto;
            ActualizarSaldo(nuevoSaldo);

            Console.WriteLine($"Se extrajeron ${monto}");
            return true;
        }
    }
}
