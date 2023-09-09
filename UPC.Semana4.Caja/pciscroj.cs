using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.Semana4.Caja
{
    public class pciscroj
    {
        public List<CajaBE> CrearSistemaDeCajas(int cantidad) { 
            var cajas = new List<CajaBE>();
            for(int i = 0; i < cantidad; i++)
            {
                var caja = new CajaBE();
                caja.id_caja = "CAJA " + (i+1);
                caja.nombre_cajero = "Nombre cajero " + (i + 1);

                cajas.Add(caja);
            }

            return cajas;
        }
    }
}
