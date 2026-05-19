using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej_5
{
    public class Banco
    {
        private List<CuentaBancaria> cuentasRegistradas;

        public Banco()
        {
            this.cuentasRegistradas = new List<CuentaBancaria>();
        }
        public void agregarCuenta(CuentaBancaria cuenta)
        {
            cuentasRegistradas.Add(cuenta);
            Console.WriteLine("Cuenta registrada exitosamente en el Banco.");
        }
        public void transferir(CuentaBancaria origen, CuentaBancaria destino, int monto)
        {
            Console.WriteLine($"\nIntentando transferir ${monto}");

            if (monto <= 0)
            {
                Console.WriteLine("El monto debe ser mayor a 0.");
                return;
            }

            if (cuentasRegistradas.Contains(origen) == false || cuentasRegistradas.Contains(destino) == false)
            {
                Console.WriteLine("Una o ambas cuentas no están registradas en este banco.");
                return;
            }

            bool extraccionExitosa = origen.extraer(monto);

            if (extraccionExitosa == true)
            {
                destino.depositar(monto);
                Console.WriteLine("Transferencia realizada con éxito.");
            }
            else
            {
                Console.WriteLine("Transferencia cancelada.");
            }
        }
    }
}