using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_5        
{
    public class CuentaBancaria
    {
        private int saldo;

        public CuentaBancaria()
        {
            this.saldo = 0;
        }

        public void depositar(int monto)
        {
            if (monto < 0)
            {
                Console.WriteLine("Error: El monto tiene q ser mayor a 0");
                return;
            }
            saldo += monto;
            Console.WriteLine($"Se depositaron ${monto}");
        }
        public virtual bool extraer(int monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("Error: el monto tiene q ser mayor a 0");
                return false;
            }
            saldo -= monto;
            return true;
        }

        public void mostrarSaldo()
        {
            Console.WriteLine($"saldo actual: ${saldo}");
        }
        protected int ObtenerSaldo()
        {
            return saldo;
        }

        protected void ActualizarSaldo(int nuevoSaldo)
        {
            saldo = nuevoSaldo;
        }
    }
}