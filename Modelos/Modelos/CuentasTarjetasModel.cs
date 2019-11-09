using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class CuentasTarjetasModel
    {
        public decimal Monto { get; set; }
        public int clave { get; set; }
        public string NroCuenta { get; set; }
        public string NroCuentaDestino { get; set; }
        public int doi { get; set; }
        public string Usuario { get; set; }
        public byte[] RowVersionD { get; set; }
        public byte[] RowVersion { get; set; }
        public int ClaveTarjeta { get; set; }
        public string NroTarjeta { get; set; }

        public CuentasTarjetasModel() { }
    }
}
