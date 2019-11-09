using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
   public class Deposito
    {
        public string NroCuenta { get; set; }
        public decimal Monto { get; set; }
        public string Doi { get; set; }

        public string Usuario { get; set; }
        public byte[] RowVer { get; set; }

        public Deposito() { }
    }
}
