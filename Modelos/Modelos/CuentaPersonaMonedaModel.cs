using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
  public  class CuentaPersonaMonedaModel
    {
        public string Cliente { get; set; }
        public string TipoCuenta { get; set; }
        public string Estado { get; set; }
        public string Moneda { get; set; }
        public byte[] Version { get; set; }
    }
}
