using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_5
{
    public class CuentaCorriente : CuentaBancaria
    {
        private int limiteDescubierto;
        public CuentaCorriente(int descubierto)
        {
            this.limiteDescubierto = descubierto;
        }
        public override bool extraer(int monto)
        {
            if (monto < 0)
            {
                Console.WriteLine("El monto tiene q ser mayor a 0");
                return false;
            }

            int saldoResultante = ObtenerSaldo() - monto;

            if (saldoResultante < -limiteDescubierto)
            {
                Console.WriteLine($"Supera el límite de descubierto de ${limiteDescubierto}.");
                return false;
            }

            ActualizarSaldo(saldoResultante);
            Console.WriteLine($"Se extrajeron ${monto}");
            return true;
        }
    }
}
