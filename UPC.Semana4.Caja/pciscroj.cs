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

        public void RegistrarCompraEnCaja(CompraBE objCompra, CajaBE objCaja)
        {
            objCompra.fecha = DateTime.Now;
            objCaja.compras.Add(objCompra);
            Console.WriteLine("La compra se ha realizado a las " + objCompra.fecha.ToString("dd/MM/yyyy HH:mm"));
            Console.WriteLine("con nro documento: " + objCompra.nro_documento);
            Console.WriteLine("por un monto de; " + objCompra.monto_compra);
            Console.WriteLine(String.Format("La {0} tiene {1} compras", objCaja.id_caja, objCaja.compras.Count));
        }
    }
}
