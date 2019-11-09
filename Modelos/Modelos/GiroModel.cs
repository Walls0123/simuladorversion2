using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class GiroModel
    {
        public int Id { get; set; }
        public int Id_PersonaOrigen { get; set; }
        public int Id_PersonaDestino { get; set; }
        public decimal Monto { get; set; }
        public bool Estado { get; set; }
        public int Id_Movimiento { get; set; }
        public DateTime FechaGiro { get; set; }
        public DateTime FechaRetiro { get; set; }
        public DateTime? FECHA_MODIFICACION { get; set; }
        public string USUARIO_CREADOR { get; set; }
        public string USUARIO_MODIFICADOR { get; set; }
        public DateTime FECHA_CREACION { get; set; }
        public byte Clave { get; set; }
        public string Moneda { get; set; }
        public byte[] RowVer { get; set; }
    }
}
