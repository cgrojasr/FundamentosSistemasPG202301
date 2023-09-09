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
            var cajas = solucion.CrearSistemaDeCajas(4);
            for(int i = 0; i < cajas.Count; i++)
            {
                Console.WriteLine(cajas[i].id_caja + ": " + cajas[i].nombre_cajero);
            }
            Console.ReadLine();
        }
    }
}
