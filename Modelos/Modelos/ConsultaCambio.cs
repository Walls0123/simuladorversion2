using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
   public class ConsultaCambio
    {
        public int ID { get; set; }
        public decimal Compra { get; set; }
        public decimal Venta { get; set; }
        public DateTime Fecha { get; set; }
    }
}
