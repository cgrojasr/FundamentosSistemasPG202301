using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.Semana4.Caja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solucion = new pciscroj();
            Console.WriteLine("¿Cuantas cajas necesitas?");
            var cantidadCajas = int.Parse(Console.ReadLine());
            var cajas = solucion.CrearSistemaDeCajas(cantidadCajas);
            for(int i = 0; i < cantidadCajas; i++)
            {
                Console.WriteLine(cajas[i].id_caja + ": " + cajas[i].nombre_cajero);
            }

            var abierto = true;
            while (abierto) {
                Console.WriteLine("Por favor escoge una caja del 1 al " + cantidadCajas + " para pagar tus productos: ");
                var nroCaja = int.Parse(Console.ReadLine());
                var objCompra = new CompraBE();
                Console.Write("Nro. Doc. Identidad: ");
                objCompra.nro_documento = Console.ReadLine();
                Console.Write("Monto de la compra: ");
                objCompra.monto_compra = decimal.Parse(Console.ReadLine());
                solucion.RegistrarCompraEnCaja(objCompra, cajas[nroCaja - 1]);

                Console.WriteLine("¿Tenemos más clientes? (S/N)");
                var respuesta = Console.ReadLine();
                if(respuesta == "N") {
                    abierto = false;
                }
            }

            Console.ReadLine();
        }
    }
}
