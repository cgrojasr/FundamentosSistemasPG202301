using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPC.Semana4.Caja
{
    public class CajaBE
    {
        public string id_caja { get; set; }
        public string nombre_cajero { get; set; }
        public List<CompraBE> compras { get; set; } = new List<CompraBE>();
    }
}
